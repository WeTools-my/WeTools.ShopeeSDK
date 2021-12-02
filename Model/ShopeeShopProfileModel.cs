using Newtonsoft.Json;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeShopProfileModel : ShopeeBaseModel
    {
        public ShopeeShopProfileResponseModel Response { get; set; }
    }

    public class ShopeeShopProfileResponseModel
    {
        [JsonProperty(PropertyName = "shop_logo")]
        public string ShopLogo { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "shop_name")]
        public string ShopName { get; set; }
    }
}
