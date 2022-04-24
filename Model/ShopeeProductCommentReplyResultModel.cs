using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeProductCommentReplyResultModel : ShopeeBaseModel
    {
        public ShopeeProductCommentReplyResponse Response { get; set; }
    }

    public class ShopeeProductCommentReplyResponse
    {
        [JsonProperty("result_list")]
        public List<ShopeeProductCommentReplyResultListModel> ResultList { get; set; }
    }

    public class ShopeeProductCommentReplyResultListModel
    {
        [JsonProperty("comment_id")]
        public long CommentId { get; set; }

        [JsonProperty("fail_error")]
        public string FailError { get; set; }

        [JsonProperty("fail_message")]
        public string FailMessage { get; set; }
    }
}
