using Newtonsoft.Json;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeProductUpdatePriceRequestModel
    {
        [JsonProperty("model_id")]
        public long ModelId { get; set; }

        [JsonProperty("original_price")]
        public decimal OriginalPrice { get; set; }
    }
}
