using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeProductItemSearchModel:ShopeeBaseModel
    {
        public ShopeeProductItemSearchResponseModel Response { get; set; }
    }

    public class ShopeeProductItemSearchResponseModel
    {
        [JsonProperty("item_id_list")]
        public List<long> ItemIdList { get; set; }

        [JsonProperty("next_offset")]
        public string NextOffset { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }
}
