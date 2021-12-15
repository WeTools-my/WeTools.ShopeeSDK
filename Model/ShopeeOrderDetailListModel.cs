using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeTools.ShopeeSDK.Model
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ShopeeOrderDetailImageInfoModel
    {
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class ShopeeOrderDetailItemModel
    {
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("item_sku")]
        public string ItemSku { get; set; }

        [JsonProperty("model_id")]
        public long ModelId { get; set; }

        [JsonProperty("model_name")]
        public string ModelName { get; set; }

        [JsonProperty("model_sku")]
        public string ModelSku { get; set; }

        [JsonProperty("model_quantity_purchased")]
        public int ModelQuantityPurchased { get; set; }

        [JsonProperty("model_original_price")]
        public decimal ModelOriginalPrice { get; set; }

        [JsonProperty("model_discounted_price")]
        public decimal ModelDiscountedPrice { get; set; }

        [JsonProperty("wholesale")]
        public bool Wholesale { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("add_on_deal")]
        public bool AddOnDeal { get; set; }

        [JsonProperty("main_item")]
        public bool MainItem { get; set; }

        [JsonProperty("add_on_deal_id")]
        public long AddOnDealId { get; set; }

        [JsonProperty("promotion_type")]
        public string PromotionType { get; set; }

        [JsonProperty("promotion_id")]
        public long PromotionId { get; set; }

        [JsonProperty("order_item_id")]
        public long OrderItemId { get; set; }

        [JsonProperty("promotion_group_id")]
        public long PromotionGroupId { get; set; }

        [JsonProperty("image_info")]
        public ShopeeOrderDetailImageInfoModel ImageInfo { get; set; }
    }

    public class ShopeeOrderDetailPackageModel
    {
        [JsonProperty("package_number")]
        public string PackageNumber { get; set; }

        [JsonProperty("logistics_status")]
        public string LogisticsStatus { get; set; }

        [JsonProperty("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonProperty("item_list")]
        public List<ShopeeOrderDetailItemModel> ItemList { get; set; }
    }

    public class ShopeeOrderDetailRecipientAddressModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("full_address")]
        public string FullAddress { get; set; }
    }

    public class ShopeeOrderDetailModel
    {
        [JsonProperty(" checkout_shipping_carrier")]
        public object CheckoutShippingCarrier { get; set; }

        //[JsonProperty(" reverse_shipping_fee.")]
        //public object ReverseShippingFee { get; set; }

        [JsonProperty("actual_shipping_fee ")]
        public object ActualShippingFee { get; set; }

        [JsonProperty("actual_shipping_fee_confirmed")]
        public bool ActualShippingFeeConfirmed { get; set; }

        [JsonProperty("buyer_cancel_reason")]
        public string BuyerCancelReason { get; set; }

        [JsonProperty("buyer_cpf_id")]
        public object BuyerCpfId { get; set; }

        [JsonProperty("buyer_user_id")]
        public long BuyerUserId { get; set; }

        [JsonProperty("buyer_username")]
        public string BuyerUsername { get; set; }

        [JsonProperty("cancel_by")]
        public string CancelBy { get; set; }

        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        [JsonProperty("cod")]
        public bool Cod { get; set; }

        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("days_to_ship")]
        public int DaysToShip { get; set; }

        [JsonProperty("dropshipper")]
        public string Dropshipper { get; set; }

        [JsonProperty("dropshipper_phone")]
        public string DropshipperPhone { get; set; }

        [JsonProperty("estimated_shipping_fee")]
        public double EstimatedShippingFee { get; set; }

        [JsonProperty("fulfillment_flag")]
        public string FulfillmentFlag { get; set; }

        [JsonProperty("goods_to_declare")]
        public bool GoodsToDeclare { get; set; }

        [JsonProperty("invoice_data")]
        public object InvoiceData { get; set; }

        [JsonProperty("item_list")]
        public List<ShopeeOrderDetailItemModel> ItemList { get; set; }

        [JsonProperty("message_to_seller")]
        public string MessageToSeller { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("note_update_time")]
        public int NoteUpdateTime { get; set; }

        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        [JsonProperty("package_list")]
        public List<ShopeeOrderDetailPackageModel> PackageList { get; set; }

        [JsonProperty("pay_time")]
        public int PayTime { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("pickup_done_time")]
        public int PickupDoneTime { get; set; }

        [JsonProperty("recipient_address")]
        public ShopeeOrderDetailRecipientAddressModel RecipientAddress { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("reverse_shipping_fee")]
        public decimal ReverseShippingFee { get; set; }

        [JsonProperty("ship_by_date")]
        public int ShipByDate { get; set; }

        [JsonProperty("shipping_carrier")]
        public string ShippingCarrier { get; set; }

        [JsonProperty("split_up")]
        public bool SplitUp { get; set; }

        [JsonProperty("total_amount")]
        public decimal TotalAmount { get; set; }

        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }
    }

    public class ShopeeOrderDetailListResponseModel
    {
        [JsonProperty("order_list")]
        public List<ShopeeOrderDetailModel> OrderList { get; set; }
    }

    public class ShopeeOrderDetailListModel:ShopeeBaseModel
    {
        [JsonProperty("response")]
        public ShopeeOrderDetailListResponseModel Response { get; set; }
    }


}
