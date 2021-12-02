using Newtonsoft.Json;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeProductUpdateStockRequestModel
    {
        [JsonProperty("model_id")]
        public long ModelId { get; set; }

        [JsonProperty("normal_stock")]
        public int NormalStock { get; set; }
    }
}
