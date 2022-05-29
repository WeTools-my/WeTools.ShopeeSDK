using System.Collections.Generic;
using WeTools.ShopeeSDK.Util;

namespace WeTools.ShopeeSDK
{
    /// <summary>
    /// shopee sdk client 
    /// clrs
    /// </summary>
    public class ShopeeClient
    {
        public ShopeeAPI? V2 { get; set; }
        public ShopeeAPIBasic? Basic { get; set; }

        public ShopeeClient(long partnerId,string partnerKey)
        {
            V2 = new ShopeeAPI
            {
                Basic = new ShopeeAPIBasic
                {
                    Web = new WebUtils(),
                    PartnerId = partnerId,
                    PartnerKey = partnerKey
                }
            };

            Basic = V2.Basic;
        }

        public ShopeeClient(long partnerId, string partnerKey,long shopId)
        {
            V2 = new ShopeeAPI
            {
                Basic = new ShopeeAPIBasic
                {
                    Web = new WebUtils(),
                    PartnerId = partnerId,
                    PartnerKey = partnerKey,
                    ShopId = shopId
                }
            };

            Basic = V2.Basic;
        }
        public void SetShopId(long shopId)
        {
            Basic.ShopId = shopId;
        }

        public void SetDebug(bool isdebug=true)
        {
            Basic.IsDebug = isdebug;
        }

        public void SetTimeout(int timeout)
        {
            Basic.Web.Timeout = timeout;
        }
        //public void SetSignMethod(string signMethod)
        //{
        //    if (signMethod.Equals(Constants.SIGN_METHOD_HMAC) || signMethod.Equals(Constants.SIGN_METHOD_SHA256))
        //    {
        //        this.signMethod = signMethod;
        //    }
        //}

        public void SetReadWriteTimeout(int readWriteTimeout)
        {
            Basic.Web.ReadWriteTimeout = readWriteTimeout;
        }

        public void SetDisableTrace(bool disableTrace)
        {
            //this.disableTrace = disableTrace;
        }

        public void SetIgnoreSSLCheck(bool ignore)
        {
            Basic.Web.IgnoreSSLCheck = ignore;
        }

        /// <summary>
        /// disable local proxy
        /// </summary>
        public void SetDisableWebProxy(bool disable)
        {
            Basic.Web.DisableWebProxy = disable;
        }

        public void SetMaxConnectionLimit(int limit)
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = limit;
        }

        public void SetCustomParameters(IDictionary<string, string> customParameters)
        {
            //this.customParameters = customParameters;
        }
    }


}
