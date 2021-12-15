using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ShopeeProductCommentCmtReplyModel
    {
        [JsonProperty("reply")]
        public string Reply { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
    }

    public class ShopeeProductCommentModel
    {
        [JsonProperty("comment_id")]
        public long CommentId { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("buyer_username")]
        public string BuyerUsername { get; set; }

        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("model_id")]
        public long ModelId { get; set; }

        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        [JsonProperty("rating_star")]
        public int RatingStar { get; set; }

        [JsonProperty("editable")]
        public string Editable { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("cmt_reply")]
        public ShopeeProductCommentCmtReplyModel CmtReply { get; set; }
    }

    public class ShopeeProductCommentListResponseModel
    {
        [JsonProperty("item_comment_list")]
        public List<ShopeeProductCommentModel> ItemCommentList { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }
    }

    public class ShopeeProductCommentListModel:ShopeeBaseModel
    {
        [JsonProperty("response")]
        public ShopeeProductCommentListResponseModel Response { get; set; }

    }


}
