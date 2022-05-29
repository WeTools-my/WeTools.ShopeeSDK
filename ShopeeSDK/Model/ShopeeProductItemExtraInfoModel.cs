using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ShopeeProductItemExtraInfoItemModel
    {
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("sale")]
        public int Sale { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("rating_star")]
        public double RatingStar { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }
    }

    public class ShopeeProductItemExtraInfoResponseModel
    {
        [JsonProperty("item_list")]
        public List<ShopeeProductItemExtraInfoItemModel> ItemList { get; set; }
    }

    public class ShopeeProductItemExtraInfoModel:ShopeeBaseModel
    {
        [JsonProperty("warning")]
        public string Warning { get; set; }

        [JsonProperty("response")]
        public ShopeeProductItemExtraInfoResponseModel Response { get; set; }
    }


}
