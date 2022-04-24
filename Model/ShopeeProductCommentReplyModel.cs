using Newtonsoft.Json;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeProductCommentReplyModel
    {
        [JsonProperty("comment_id")]
        public long CommentId { get; set; }

        public string Comment { get; set; }
    }
}
