using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeAccesstokenModel:ShopeeBaseModel
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// miao
        /// </summary>
        [JsonProperty(PropertyName = "expire_in")]
        public string ExpireIn { get; set; }

        [JsonProperty(PropertyName = "merchant_id_list")]
        public List<int> MerchantIdList { get; set; }

        [JsonProperty(PropertyName = "shop_id_list")]
        public string ShopIdList { get; set; }

        [JsonProperty(PropertyName = "merchant_id")]
        public List<int> MerchantId { get; set; }

        [JsonProperty(PropertyName = "shop_id")]
        public string ShopId { get; set; }

        [JsonProperty(PropertyName = "partner_id")]
        public string PartnerId { get; set; }
    }
}
