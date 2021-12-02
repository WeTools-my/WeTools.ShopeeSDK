using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace WeTools.ShopeeSDK.Util
{
    public abstract class ShopeeUtils
    {
        private static string intranetIp;

        /// <summary>
        /// Sign API Request.
        /// </summary>
        /// <param name="parameters">all api params</param>
        /// <param name="appSecret">app secret</param>
        /// <param name="signMethod">sign method : sha256, hmac</param>
        /// <returns>sign</returns>
        public static string SignRequest(string apiName, IDictionary<string, string> parameters, string appSecret, string signMethod)
        {
            return SignRequest(apiName, parameters, null, appSecret, signMethod);
        }

        public static string AuthSignRequest(string data)
        {
            return Sha256(data);
        }

        public static string AuthSignRequest(string data,string partnerKey)
        {
            return HmacSha256(data, partnerKey).ToLower();
        }
        /// <summary>
        /// Sign API Request.
        /// </summary>
        /// <param name="parameters">all api params</param>
        /// <param name="appSecret">app secret</param>
        /// <param name="signMethod">sign method : sha256, hmac</param>
        /// <returns>sign</returns>
        public static string SignRequest(string apiUrl, IDictionary<string, string> parameters, string partnerKey)
        {
            string signData = apiUrl;
            foreach (var key in parameters.Keys)
            {
                signData += $"|{parameters[key]}";
            }

            return HmacSha256(signData, partnerKey).ToLower();
            //return SignRequest(apiUrl, parameters, null, appSecret, signMethod);
        }

        private static string HmacSha256(string data, string key)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                var result = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    sb.Append(result[i].ToString("x2"));
                }
                return sb.ToString();
                //return BitConverter.ToString(result).Replace("-", "").ToLower();
            }
        }


        private static string Sha256(string data)
        {
            byte[] bytValue = Encoding.UTF8.GetBytes(data);

            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                byte[] retVal = sha256.ComputeHash(bytValue);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();

                //var result = hmac.ComputeHash(Encoding.ASCII.GetBytes(data));
                //return BitConverter.ToString(result).Replace("-", "").ToLower();
            }
        }
        /// <summary>
        /// Sign API Request with body.
        /// </summary>
        /// <param name="parameters">all api params</param>
        /// <param name="body">body</param>
        /// <param name="appSecret">app secret</param>
        /// <param name="signMethod">sign method : sha256, hmac</param>
        /// <returns>sign</returns>
        public static string SignRequest(string apiName, IDictionary<string, string> parameters, string body, string appSecret, string signMethod)
        {
            // first : sort all key with asci order
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);

            // second : contact all params with key order
            StringBuilder query = new StringBuilder();

            query.Append(apiName);

            foreach (KeyValuePair<string, string> kv in sortedParams)
            {
                if (!string.IsNullOrEmpty(kv.Key) && !string.IsNullOrEmpty(kv.Value))
                {
                    query.Append(kv.Key).Append(kv.Value);
                }
            }

            // third : add body to last
            if (!string.IsNullOrEmpty(body))
            {
                query.Append(body);
            }

            // next : sign the string
            byte[] bytes = null;
            if (signMethod.Equals(Constants.SIGN_METHOD_SHA256))
            {
                HMACSHA256 sha256 = new HMACSHA256(Encoding.UTF8.GetBytes(appSecret));
                bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));
            }
            else
            {
                throw new Exception("Invalid Sign Method");
            }

            // finally : transfer binary byte to hex string
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }

            return result.ToString();
        }

        /// <summary>
        /// get local ip
        /// </summary>
        public static string GetIntranetIp()
        {
            if (intranetIp == null)
            {
                NetworkInterface[] nis = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in nis)
                {
                    if (OperationalStatus.Up == ni.OperationalStatus && (NetworkInterfaceType.Ethernet == ni.NetworkInterfaceType || NetworkInterfaceType.Wireless80211 == ni.NetworkInterfaceType))
                    {
                        foreach (UnicastIPAddressInformation info in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (AddressFamily.InterNetwork == info.Address.AddressFamily)
                            {
                                intranetIp = info.Address.ToString();
                                break;
                            }
                        }
                        if (intranetIp != null) break;
                    }
                }
            }
            if (intranetIp == null)
            {
                intranetIp = "127.0.0.1";
            }
            return intranetIp;
        }
    }
}
