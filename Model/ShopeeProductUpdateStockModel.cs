using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeProductUpdateStockFailureModel
    {
        [JsonProperty("model_id")]
        public long ModelId { get; set; }

        [JsonProperty("failed_reason")]
        public string FailedReason { get; set; }
    }

    public class ShopeeProductUpdateStockSuccessModel
    {
        [JsonProperty("model_id")]
        public long ModelId { get; set; }

        [JsonProperty("original_price")]
        public double OriginalPrice { get; set; }
    }

    public class ShopeeProductUpdateStockResponseModel
    {
        [JsonProperty("failure_list")]
        public List<ShopeeProductUpdateStockFailureModel> FailureList { get; set; }

        [JsonProperty("success_list")]
        public List<ShopeeProductUpdateStockSuccessModel> SuccessList { get; set; }
    }

    public class ShopeeProductUpdateStockModel : ShopeeBaseModel
    {

        [JsonProperty("response")]
        public ShopeeProductUpdateStockResponseModel Response { get; set; }
    }
}
