using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeAccesstokenModel : ShopeeBaseModel
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// miao
        /// </summary>
        [JsonProperty(PropertyName = "expire_in")]
        public int ExpireIn { get; set; }

        [JsonProperty(PropertyName = "merchant_id_list")]
        public List<long> MerchantIdList { get; set; }

        [JsonProperty(PropertyName = "shop_id_list")]
        public List<long> ShopIdList { get; set; }

        [JsonProperty(PropertyName = "merchant_id")]
        public long MerchantId { get; set; }

        [JsonProperty(PropertyName = "shop_id")]
        public long ShopId { get; set; }

        [JsonProperty(PropertyName = "partner_id")]
        public long PartnerId { get; set; }
    }
}
