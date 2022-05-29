namespace WeTools.ShopeeSDK
{
    public class ShopeePublicParams
    {
        public long PartnerId { get; set; }
        public string PartnerKey { get; set; }


        public long ShopId { get; set; }
        public long MerchantId { get; set; }


        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }


        public bool IsDebug { get; set; } = false;

        private string Api { get; } = "api";
        public string Version { get; set; } = "v2";


        public string UATGatewayUrl { get; set; } = "https://partner.test-stable.shopeemobile.com";
        public string GatewayUrl { get; set; } = "https://partner.shopeemobile.com";

        public string Host => IsDebug ? UATGatewayUrl : GatewayUrl;

        public string APIVersionPath => $"/{Api}/{Version}";

        public override string ToString()
        {
            string url = IsDebug ? UATGatewayUrl : GatewayUrl;
            return $"{url}{APIVersionPath}";
        }
    }
}
