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

    public class ShopeeProductUpdateStockSellerStockModel
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }
    }
}
