using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ShopeeShopCategoryItemResponseModel
    {
        [JsonProperty("item_list")]
        public List<long> ItemList { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class ShopeeShopCategoryItemModel:ShopeeBaseModel
    {

        [JsonProperty("response")]
        public ShopeeShopCategoryItemResponseModel Response { get; set; }
    }


}
