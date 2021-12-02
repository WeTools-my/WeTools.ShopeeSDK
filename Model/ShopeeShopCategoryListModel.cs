using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeShopCategoryModel
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("shop_category_id")]
        public int ShopCategoryId { get; set; }

        [JsonProperty("sort_weight")]
        public int SortWeight { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ShopeeShopCategoryResponseModel
    {
        [JsonProperty("shop_categorys")]
        public List<ShopeeShopCategoryModel> ShopCategorys { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class ShopeeShopCategoryListModel:ShopeeBaseModel
    {
       
        [JsonProperty("response")]
        public ShopeeShopCategoryResponseModel Response { get; set; }
    }


}
