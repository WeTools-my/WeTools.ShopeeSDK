using Newtonsoft.Json;
using System;

namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeAPIBase
    {
        internal string ApiType { get; set; }
        internal ShopeeAPIBasic? _basic { get; set; }

        internal virtual string GetApiPath(string action)
        {
            return $"{_basic.ApiVersion}/{ApiType}/{action}";
        }

        internal virtual string GetHostUrl(string action)
        {
            return $"{_basic.Host}{_basic.ApiVersion}/{ApiType}/{action}";
        }

        internal virtual string GetRequestUrl(string action, string queryString = "")
        {
            string hostUrl = GetHostUrl(action);
            string apiPath = GetApiPath(action);

            var signInfo = _basic.GetPublicSign(apiPath);

            return $"{hostUrl}?partner_id={_basic.PartnerId}&timestamp={signInfo.Item2}&sign={signInfo.Item1}{queryString}";
        }

        internal virtual string GetRequestUrl(string action, SignTypeEnum signType, string queryString="")
        {
            string hostUrl = GetHostUrl(action);
            string apiPath = GetApiPath(action);

            var signInfo=ValueTuple.Create<string,long>("",0);
            switch (signType)
            {
                case SignTypeEnum.Public:
                    signInfo = _basic.GetPublicSign(apiPath);
                    break;
                case SignTypeEnum.Shop:
                    signInfo = _basic.GetShopSign(apiPath);
                    break;
                case SignTypeEnum.Merchant:
                    signInfo = _basic.GetMerchantSign(apiPath);
                    break;
            }
             
            return $"{hostUrl}?partner_id={_basic.PartnerId}&timestamp={signInfo.Item2}&sign={signInfo.Item1}{queryString}";        
        }

        internal virtual string MakeData<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        internal virtual T ParseData<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
