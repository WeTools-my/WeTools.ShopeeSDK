using System;

namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeAPIBasic
    {
        public long PartnerId { get; set; }
        public string? PartnerKey { get; set; }

        public long ShopId { get; set; }
        public long MerchantId { get; set; }

        public string? AccessToken { get; set; }

        public string? RefreshToken { get; set; }

        public bool IsDebug { get; set; } = false;
        public string Api { get; } = "api";
        public string Version { get; set; } = "v2";

        public string UATGatewayUrl { get; set; } = "https://partner.test-stable.shopeemobile.com";
        public string GatewayUrl { get; set; } = "https://partner.shopeemobile.com";

        public string Host => GetGatewayUrl();

        public string ApiVersion => GetApiVersion();

        public WebUtils? Web { get; set; }

        public string GetGatewayUrl()
        {
            return IsDebug ? UATGatewayUrl : GatewayUrl;
        }

        public string GetApiVersion()
        {
            return $"/{Api}/{Version}";
        }
        public override string ToString()
        {
            string url = IsDebug ? UATGatewayUrl : GatewayUrl;
            return $"{url}/{Api}/{Version}";
        }

        internal (string,long) GetPublicSign(string apiPath)
        {
            DateTime start = DateTime.Now;
            long timest = ((DateTimeOffset)start).ToUnixTimeSeconds();

            string data = $"{PartnerId}{apiPath}{timest}";
            string sign = ShopeeUtils.AuthSignRequest(data, PartnerKey);

            return (sign, timest);
        }

        internal (string,long ) GetShopSign(string apiPath)
        {
            DateTime start = DateTime.Now;
            long timest = ((DateTimeOffset)start).ToUnixTimeSeconds();

            string data = $"{PartnerId}{apiPath}{timest}{AccessToken}{ShopId}";
            string sign = ShopeeUtils.AuthSignRequest(data, PartnerKey);

            return (sign, timest);
        }

        internal (string,long) GetMerchantSign(string apiPath)
        {
            DateTime start = DateTime.Now;
            long timest = ((DateTimeOffset)start).ToUnixTimeSeconds();

            string data = $"{PartnerId}{apiPath}{timest}{AccessToken}{MerchantId}";
            string sign = ShopeeUtils.AuthSignRequest(data, PartnerKey);

            return (sign, timest);
        }
    }


}
