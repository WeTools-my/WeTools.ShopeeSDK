using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ShopeeProductUpdatePriceFailureModel
    {
        [JsonProperty("model_id")]
        public int ModelId { get; set; }

        [JsonProperty("failed_reason")]
        public string FailedReason { get; set; }
    }

    public class ShopeeProductUpdatePriceSuccessModel
    {
        [JsonProperty("model_id")]
        public int ModelId { get; set; }

        [JsonProperty("original_price")]
        public double OriginalPrice { get; set; }
    }

    public class ShopeeProductUpdatePriceResponseModel
    {
        [JsonProperty("failure_list")]
        public List<ShopeeProductUpdatePriceFailureModel> FailureList { get; set; }

        [JsonProperty("success_list")]
        public List<ShopeeProductUpdatePriceSuccessModel> SuccessList { get; set; }
    }

    public class ShopeeProductUpdatePriceModel:ShopeeBaseModel
    {

        [JsonProperty("response")]
        public ShopeeProductUpdatePriceResponseModel Response { get; set; }
    }


}
