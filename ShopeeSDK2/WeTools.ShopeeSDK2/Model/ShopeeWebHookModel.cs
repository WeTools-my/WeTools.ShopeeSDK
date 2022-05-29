using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeWebHookBaseModel
    {
        [JsonProperty("shop_id")]
        public long ShopId { get; set; }

        public ShopeeWebHookCode Code { get; set; }

        public long TimeStamp { get; set; }

    }

   public class ShopeeWebHookAuthModel:ShopeeWebHookBaseModel
    {
        public int Success { get; set; }

        public bool IsSuccess => Success == 1;
        public string Extra { get; set; }
    }

    public class ShopeeWebHookBrandRegisterModel : ShopeeWebHookBaseModel
    {
        [JsonProperty("register_brand")]
        public ShopeeWebHookBrandInfo RegisterBrand { get; set; }

        [JsonProperty("register_result")]
        public ShopeeWebHookBrandRegisterResult RegisterResult { get; set; }

        [JsonProperty("combined_brand")]
        public ShopeeWebHookBrandInfo CombinedBrand { get; set; }
    }

   public class ShopeeWebHookBrandInfo
    {
        [JsonProperty("brand_id")]
        public long BrandId { get; set; }

        [JsonProperty("brand_name")]
        public string BrandName { get; set; }
    }


    public class ShopeeWebHookBrandRegisterResult
    {
        public string Result { get; set; }

        public string Reason { get; set; }
    }

    public class ShopeeWebHookTokenExpiryModel : ShopeeWebHookBaseModel
    {
        public ShopeeWebHookTokenExpiryData Data { get; set; }
    }

    public class ShopeeWebHookTokenExpiryData
    {
        [JsonProperty("total_page")]
        public int TotalPage { get; set; }

        [JsonProperty("page_no")]
        public int PageNo { get; set; }

        [JsonProperty("expire_before")]
        public long ExpireBefore { get; set; }

        [JsonProperty("merchant_expire_soon")]
        public List<long> MerchantExpireSoon { get; set; }

        [JsonProperty("shop_expire_soon")]
        public List<long> ShopExpireSoon { get; set; }
    }

    public class ShopeeWebHookOrderStatusModel : ShopeeWebHookBaseModel
    {
        public ShopeeWebHookOrderStatusData Data { get; set; }
    }
    public class ShopeeWebHookOrderStatusData
    {
        public string OrderSn { get; set; }

        public string Status { get; set; }

        [JsonProperty("update_time")]
        public long UpdateTime { get; set; }
    }

    public class ShopeeWebHookTrackingNoModel : ShopeeWebHookBaseModel
    {
        public ShopeeWebHookTrackingNoData Data { get; set; }
    }

    public class ShopeeWebHookTrackingNoData
    {
        public string OrderSn { get; set; }

        public string TrackingNo { get; set; }
    }

    public class ShopeeWebHookShopeeUpdateModel : ShopeeWebHookBaseModel
    {
        public ShopeeWebHookShopeeUpdateData Data { get; set; }
    }

    public class ShopeeWebHookShopeeUpdateData
    {
        public List<ShopeeWebHookShopeeUpdateAction> Actions { get; set; }
    }

    public class ShopeeWebHookShopeeUpdateAction
    {
        public string Content { get; set; }

        [JsonProperty("update_time")]
        public long UpdateTime { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

    }

    public class ShopeeWebHookBannedItemModel : ShopeeWebHookBaseModel
    {
        public ShopeeWebHookBannedItemData Data { get; set; }
    }

    public class ShopeeWebHookBannedItemData
    {
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        public string Name { get; set; }

        [JsonProperty("update_time")]
        public long UpdateTime { get; set; }

        [JsonProperty("reason_list")]
        public List<ShopeeWebHookBannedItemReason> ReasonList { get; set; }
    }

    public class ShopeeWebHookBannedItemReason
    {
        public string Suggestion { get; set; }

        [JsonProperty("days_to_fix")]
        public int DaysToFix { get; set; }

        [JsonProperty("violation_reason")]
        public string ViolationReason { get; set; }
        [JsonProperty("violation_type")]
        public string ViolationType { get; set; }

    }


    public class ShopeeWebHookItemPromotionModel : ShopeeWebHookBaseModel
    {
        public ShopeeWebHookItemPromotionData Data { get; set; }
    }

    public class ShopeeWebHookItemPromotionData
    {
        [JsonProperty("shop_id")]
        public long ShopId { get; set; }
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("promotion_id")]
        public long PromotionId { get; set; }

        [JsonProperty("veriation_id")]
        public long VeriationId { get; set; }

        public string Action { get; set; }

        [JsonProperty("end_time")]
        public long EndTime { get; set; }

        [JsonProperty("update_time")]
        public long UpdateTime { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("promotion_type")]
        public string PromotionType { get; set; }

        [JsonProperty("reserved_stock")]
        public int ReservedStock { get; set; }
    }


    public class ShopeeWebHookReservedStockModel : ShopeeWebHookBaseModel
    {
        public ShopeeWebHookReservedStockData Data { get; set; }
    }

    public class ShopeeWebHookReservedStockData
    {
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("promotion_id")]
        public long PromotionId { get; set; }

        [JsonProperty("veriation_id")]
        public long VeriationId { get; set; }

        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        public string Action { get; set; }

        [JsonProperty("update_time")]
        public long UpdateTime { get; set; }


        [JsonProperty("promotion_type")]
        public string PromotionType { get; set; }

        [JsonProperty("reserved_stock")]
        public int ReservedStock { get; set; }

        [JsonProperty("changed_values")]
        public List<ShopeeWebHookReservedStockChangedValue> ChangedValues { get; set; }
    }
    public class ShopeeWebHookReservedStockChangedValue
    {
        public string Name { get; set; }
        public int New { get; set; }
        public int Old { get; set; }
    }

    public class ShopeeWebHookVideoModel : ShopeeWebHookBaseModel
    {
        [JsonProperty("sharding_key")]
        public string ShardingKey { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        public string Token { get; set; }

        public string Source { get; set; }

        public ShopeeWebHookVideoData Data { get; set; }
    }

    public class ShopeeWebHookVideoData
    {
        [JsonProperty("video_upload_id")]
        public string VideoUploadId { get; set; }

        public string Status { get; set; }

        public string Message { get; set; }

        [JsonProperty("video_info")]
        public List<ShopeeWebHookVideoInfo> VideoInfo { get; set; }
    }
    public class ShopeeWebHookVideoInfo
    {
        [JsonProperty("video_id")]
        public string VideoId { get; set; }

        public int Duration { get; set; }


        [JsonProperty("video_url")]
        public List<ShopeeWebHookVideoUrlInfo> VideoUrl { get; set; }

        [JsonProperty("thumbnail_url")]
        public List<dynamic> ThumbnailUrl { get; set; }
    }

    public class ShopeeWebHookVideoUrlInfo
    {
        [JsonProperty("video_url_region")]
        public string VideoUrlRegion { get; set; }

        public string VideoUrl { get; set; }
    }


    public class ShopeeWebHookWebChatModel : ShopeeWebHookBaseModel
    {
        public ShopeeWebHookWebChatData Data { get; set; }
    }

    public class ShopeeWebHookWebChatData
    {
        public string Type { get; set; }

        public string Region { get; set; }

        public ShopeeWebHookWebChatContent Content { get; set; }
    }
    public class ShopeeWebHookWebChatContent
    {
        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("shop_id")]
        public long ShopId { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("from_id")]
        public long FromId { get; set; }

        [JsonProperty("to_id")]
        public long ToId { get; set; }

        [JsonProperty("from_user_name")]
        public string FromUserName { get; set; }

        [JsonProperty("to_user_name")]
        public string ToUserName { get; set; }

        [JsonProperty("message_type")]
        public string MessageType { get; set; }

        [JsonProperty("created_timestamp")]
        public long CreatedTimeStamp { get; set; }

        public string Region { get; set; }

        [JsonProperty("is_in_chatbot_session")]
        public bool IsInChatBotSession { get; set; }

        public ShopeeWebHookWebChatContentInfo Content { get; set; }
    }

    public class ShopeeWebHookWebChatContentInfo
    {
        public string Text { get; set; }
    }

}
