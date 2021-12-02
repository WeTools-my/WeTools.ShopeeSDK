using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeShopInfoModel:ShopeeBaseModel
    {
        [JsonProperty(PropertyName = "shop_name")]
        public string ShopName { get; set; }

        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "sip_affi_shops")]
        public List<SipAffiShopModel> SipAffiShops { get; set; }

        [JsonProperty(PropertyName = "is_cb")]
        public string IsCB { get; set; }

        [JsonProperty(PropertyName = "is_cnsc")]
        public string IsCNSC { get; set; }

        [JsonProperty(PropertyName = "auth_time")]
        public string AuthTime { get; set; }

        [JsonProperty(PropertyName = "expire_time")]
        public string ExpireTime { get; set; }

        [JsonProperty(PropertyName = "is_sip")]
        public string IsSip { get; set; }
    }

   public class SipAffiShopModel
    {
        [JsonProperty(PropertyName = "affi_shop_id")]
        public string AffiShopId { get; set; }

        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
    }
}
