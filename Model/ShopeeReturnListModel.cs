using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeReturnListModel : ShopeeBaseModel
    {
        [JsonProperty("response")]
        public ShopeeReturnListResponseModel Response { get; set; }
    }

    public class User
    {
        [JsonProperty("username")]
        public string Username;

        [JsonProperty("email")]
        public string Email;

        [JsonProperty("portrait")]
        public string Portrait;
    }

    public class Item
    {
        [JsonProperty("item_id")]
        public long ItemId;

        [JsonProperty("model_id")]
        public long ModelId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("images")]
        public List<string> Images;

        [JsonProperty("amount")]
        public decimal Amount;

        [JsonProperty("item_price")]
        public decimal ItemPrice;

        [JsonProperty("is_add_on_deal")]
        public bool IsAddOnDeal;

        [JsonProperty("is_main_item")]
        public bool IsMainItem;

        [JsonProperty("item_sku")]
        public string ItemSku;

        [JsonProperty("variation_sku")]
        public string VariationSku;

        [JsonProperty("add_on_deal_id")]
        public long AddOnDealId;
    }

    public class Return
    {
        [JsonProperty("image")]
        public List<string> Image;

        [JsonProperty("reason")]
        public string Reason;

        [JsonProperty("text_reason")]
        public string TextReason;

        [JsonProperty("return_sn")]
        public string ReturnSn;

        [JsonProperty("refund_amount")]
        public decimal RefundAmount;

        [JsonProperty("currency")]
        public string Currency;

        [JsonProperty("create_time")]
        public long CreateTime;

        [JsonProperty("update_time")]
        public long UpdateTime;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("due_date")]
        public int DueDate;

        [JsonProperty("tracking_number")]
        public string TrackingNumber;

        [JsonProperty("needs_logistics")]
        public bool NeedsLogistics;

        [JsonProperty("amount_before_discount")]
        public decimal AmountBeforeDiscount;

        [JsonProperty("user")]
        public User User;

        [JsonProperty("item")]
        public List<Item> Item;

        [JsonProperty("order_sn")]
        public string OrderSn;

        [JsonProperty("return_ship_due_date")]
        public long ReturnShipDueDate;

        [JsonProperty("return_seller_due_date")]
        public long ReturnSellerDueDate;

        [JsonProperty("negotiation_status")]
        public string NegotiationStatus;

        [JsonProperty("seller_proof_status")]
        public string SellerProofStatus;

        [JsonProperty("seller_compensation_status")]
        public string SellerCompensationStatus;
    }

    public class ShopeeReturnListResponseModel
    {
        [JsonProperty("more")]
        public bool More;

        [JsonProperty("return")]
        public List<Return> Return;
    }

}
