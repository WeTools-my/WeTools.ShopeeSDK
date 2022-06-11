using Newtonsoft.Json;
using System;
using WeTools.ShopeeSDK.Util;

namespace WeTools.ShopeeSDK.API
{
    public class ShopeeAPIBase
    {
        public ShopeeAPIBase(ShopeeBasicParams basicParams)
        {
            _basic = basicParams;
        }

        public ShopeeAPIBase(ShopeeBasicParams basicParams, WebUtils web)
        {
            _basic = basicParams;
            _web = web;
        }

        internal WebUtils _web { get; set; }
        internal ShopeeBasicParams _basic { get; set; }

        internal string ApiCategory { get; set; }

        #region Methods

        internal virtual string GetApiPath(string action)
        {
            return $"/{_basic.APIVersionPath}/{ApiCategory}/{action}";
        }

        internal virtual string GetHostUrl(string action)
        {
            return $"{_basic.Host}{_basic.APIVersionPath}/{ApiCategory}/{action}";
        }

        internal virtual string GetRequestUrlWithoutToken(string action, string queryString = "")
        {
            string hostUrl = GetHostUrl(action);
            string apiPath = GetApiPath(action);

            var signInfo = GetPublicSign(apiPath);

            return $"{hostUrl}?partner_id={_basic.PartnerId}&timestamp={signInfo.Item2}&sign={signInfo.Item1}{queryString}";
        }

        internal virtual string GetRequestUrl(string action, string queryString = "")
        {
            string hostUrl = GetHostUrl(action);
            string apiPath = GetApiPath(action);

            var signInfo = GetPublicSign(apiPath);

            return $"{hostUrl}?partner_id={_basic.PartnerId}&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}&timestamp={signInfo.Item2}&sign={signInfo.Item1}{queryString}";
        }

        internal virtual string GetRequestUrl(string action, SignTypeEnum signType, string queryString = "")
        {
            string hostUrl = GetHostUrl(action);
            string apiPath = GetApiPath(action);

            var signInfo = ValueTuple.Create<string, long>("", 0);
            switch (signType)
            {
                case SignTypeEnum.Public:
                    signInfo = GetPublicSign(apiPath);
                    break;
                case SignTypeEnum.Shop:
                    signInfo = GetShopSign(apiPath);
                    break;
                case SignTypeEnum.Merchant:
                    signInfo = GetMerchantSign(apiPath);
                    break;
            }

            return $"{hostUrl}?partner_id={_basic.PartnerId}&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}&timestamp={signInfo.Item2}&sign={signInfo.Item1}{queryString}";
        }

        internal virtual string MakeData<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        internal virtual T ParseData<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }

        internal (string, long) GetPublicSign(string apiPath)
        {
            DateTime start = DateTime.Now;
            long timest = ((DateTimeOffset)start).ToUnixTimeSeconds();

            string data = $"{_basic.PartnerId}{apiPath}{timest}";
            string sign = ShopeeUtils.AuthSignRequest(data, _basic.PartnerKey);

            return (sign, timest);
        }

        internal (string, long) GetShopSign(string apiPath)
        {
            DateTime start = DateTime.Now;
            long timest = ((DateTimeOffset)start).ToUnixTimeSeconds();

            string data = $"{_basic.PartnerId}{apiPath}{timest}{_basic.AccessToken}{_basic.ShopId}";
            string sign = ShopeeUtils.AuthSignRequest(data, _basic.PartnerKey);

            return (sign, timest);
        }

        internal (string, long) GetMerchantSign(string apiPath)
        {
            DateTime start = DateTime.Now;
            long timest = ((DateTimeOffset)start).ToUnixTimeSeconds();

            string data = $"{_basic.PartnerId}{apiPath}{timest}{_basic.AccessToken}{_basic.MerchantId}";
            string sign = ShopeeUtils.AuthSignRequest(data, _basic.PartnerKey);

            return (sign, timest);
        }

        #endregion
    }
}
