using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeTools.ShopeeSDK.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ShopeeProductItemBaseInfoImageModel
    {
        [JsonProperty("image_url_list")]
        public List<string> ImageUrlList { get; set; }

        [JsonProperty("image_id_list")]
        public List<string> ImageIdList { get; set; }
    }

    public class ShopeeProductItemBaseInfoDimensionModel
    {
        [JsonProperty("package_length")]
        public int PackageLength { get; set; }

        [JsonProperty("package_width")]
        public int PackageWidth { get; set; }

        [JsonProperty("package_height")]
        public int PackageHeight { get; set; }
    }

    public class ShopeeProductItemBaseInfoLogisticInfoModel
    {
        [JsonProperty("logistic_id")]
        public long LogisticId { get; set; }

        [JsonProperty("logistic_name")]
        public string LogisticName { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("is_free")]
        public bool IsFree { get; set; }

        [JsonProperty("estimated_shipping_fee")]
        public double EstimatedShippingFee { get; set; }

        [JsonProperty("shipping_fee")]
        public decimal? ShippingFee { get; set; }
    }

    public class ShopeeProductItemBaseInfoPreOrderModel
    {
        [JsonProperty("is_pre_order")]
        public bool IsPreOrder { get; set; }

        [JsonProperty("days_to_ship")]
        public int DaysToShip { get; set; }
    }

    public class ShopeeProductItemBaseInfoWholesaleModel
    {
        [JsonProperty("min_count")]
        public int MinCount { get; set; }

        [JsonProperty("max_count")]
        public int MaxCount { get; set; }

        [JsonProperty("unit_price")]
        public decimal UnitPrice { get; set; }
    }

    public class ShopeeProductItemBaseInfoVideoInfoModel
    {
        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class ShopeeProductItemBaseInfoBrandModel
    {
        [JsonProperty("brand_id")]
        public long BrandId { get; set; }

        [JsonProperty("original_brand_name")]
        public string OriginalBrandName { get; set; }
    }

    public class ShopeeProductItemBaseInfoPriceInfoModel
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("original_price")]
        public decimal OriginalPrice { get; set; }

        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }

        [JsonProperty("sip_item_price")]
        public decimal SipItemPrice { get; set; }

        [JsonProperty("sip_item_price_source")]
        public string SipItemPriceSource { get; set; }

        [JsonProperty("inflated_price_of_original_price")]
        public decimal InflatedPriceOfOriginalPrice { get; set; }

        [JsonProperty("inflated_price_of_current_price")]
        public decimal InflatedPriceOfCurrentPrice { get; set; }
    }

    public class ShopeeProductItemBaseInfoStockInfoModel
    {
        [JsonProperty("stock_type")]
        public int StockType { get; set; }

        [JsonProperty("stock_location_id")]
        public string StockLocationId { get; set; }

        [JsonProperty("current_stock")]
        public int CurrentStock { get; set; }

        [JsonProperty("normal_stock")]
        public int NormalStock { get; set; }

        [JsonProperty("reserved_stock")]
        public int ReservedStock { get; set; }
    }

    public class ShopeeProductItemBaseInfoStockInfoV2Model
    {
        [JsonProperty("summary_info")]
        public ShopeeProductItemBaseInfoStockInfoV2SummaryInfoModel SummaryInfo { get; set; }

        [JsonProperty("seller_stock")]
        public List<ShopeeProductItemBaseInfoStockInfoV2StockModel> SellerStock { get; set; }

        [JsonProperty("shopee_stock")]
        public List<ShopeeProductItemBaseInfoStockInfoV2StockModel> ShopeeStock { get; set; }

    }

    public class ShopeeProductItemBaseInfoStockInfoV2StockModel
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }
    }

    public class ShopeeProductItemBaseInfoStockInfoV2SummaryInfoModel
    {
        [JsonProperty("total_reserved_stock")]
        public int TotalReservedStock { get; set; }

        [JsonProperty("total_available_stock")]
        public int TotalAvailableStock { get; set; }
    }

    public class ShopeeProductItemBaseInfoAttributeModel
    {
        [JsonProperty("attribute_id")]
        public long AttributeId { get; set; }

        [JsonProperty("original_attribute_name")]
        public string OriginalAttributeName { get; set; }

        [JsonProperty("is_mandatory")]
        public bool IsMandatory { get; set; }

        [JsonProperty("attribute_value_list")]
        public List<ShopeeProductItemBaseInfoAttributeValueModel> AttributeValueList { get; set; }
    }

    public class ShopeeProductItemBaseInfoAttributeValueModel
    {
        [JsonProperty("value_id")]
        public long ValueId { get; set; }

        [JsonProperty("original_value_name")]
        public string OriginalValueName { get; set; }


        [JsonProperty("value_unit")]
        public string ValueUnit { get; set; }
    }

    public class ShopeeProductItemBaseInfoComplaintPolicyModel
    {
        [JsonProperty("warranty_time")]
        public string WarrantyTime { get; set; }

        [JsonProperty("exclude_entrepreneur_warranty")]
        public bool ExcludeEntrepreneurWarranty { get; set; }


        [JsonProperty("complaint_address_id")]
        public long ComplaintAddressId { get; set; }

        [JsonProperty("additional_information")]
        public string AdditionalInformation { get; set; }
    }

    public class ShopeeProductItemBaseInfoItemModel
    {
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("category_id")]
        public long CategoryId { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_sku")]
        public string ItemSku { get; set; }

        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }

        [JsonProperty("image")]
        public ShopeeProductItemBaseInfoImageModel Image { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("dimension")]
        public ShopeeProductItemBaseInfoDimensionModel Dimension { get; set; }

        [JsonProperty("logistic_info")]
        public List<ShopeeProductItemBaseInfoLogisticInfoModel> LogisticInfo { get; set; }

        [JsonProperty("pre_order")]
        public ShopeeProductItemBaseInfoPreOrderModel PreOrder { get; set; }

        [JsonProperty("wholesales")]
        public List<ShopeeProductItemBaseInfoWholesaleModel> Wholesales { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("size_chart")]
        public string SizeChart { get; set; }

        [JsonProperty("item_status")]
        public string ItemStatus { get; set; }

        [JsonProperty("has_model")]
        public bool HasModel { get; set; }

        [JsonProperty("promotion_id")]
        public long PromotionId { get; set; }

        [JsonProperty("video_info")]
        public List<ShopeeProductItemBaseInfoVideoInfoModel> VideoInfo { get; set; }

        [JsonProperty("brand")]
        public ShopeeProductItemBaseInfoBrandModel Brand { get; set; }

        [JsonProperty("item_dangerous")]
        public int ItemDangerous { get; set; }

        [JsonProperty("price_info")]
        public List<ShopeeProductItemBaseInfoPriceInfoModel> PriceInfo { get; set; }

        [JsonProperty("stock_info")]
        public List<ShopeeProductItemBaseInfoStockInfoModel> StockInfo { get; set; }

        [JsonProperty("attribute_list")]
        public List<ShopeeProductItemBaseInfoAttributeModel> AttributeList { get; set; }

        [JsonProperty("complaint_policy")]
        public ShopeeProductItemBaseInfoComplaintPolicyModel ComplaintPolicy { get; set; }

        public object TaxInfo { get; set; }

        [JsonProperty("stock_info_v2")]
        public ShopeeProductItemBaseInfoStockInfoV2Model StockInfo2 { get; set; }
    }

    public class ShopeeProductItemBaseInfoDescriptionModel
    {
        [JsonProperty("extended_description")]
        public ShopeeProductItemBaseInfoExtendedDescriptionModel ExtendedDescription { get; set; }
    }

    public class ShopeeProductItemBaseInfoExtendedDescriptionModel
    {
        [JsonProperty("field_list")]
        public List<ShopeeProductItemBaseInfoExtendedDescriptionFieldModel> FieldList { get; set; }
    }

    public class ShopeeProductItemBaseInfoExtendedDescriptionFieldModel
    {
        [JsonProperty("text")]
        public string FieldType { get; set; }


        [JsonProperty("text")]
        public string Text { get; set; }


    }

    public class ShopeeProductItemBaseInfoExtendedDescriptionFieldImageInfoModel
    {
        [JsonProperty("image_id")]
        public string ImageId { get; set; }


        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }


    }

    public class ShopeeProductItemBaseInfoResponseModel
    {
        [JsonProperty("item_list")]
        public List<ShopeeProductItemBaseInfoItemModel> ItemList { get; set; }

        /// <summary>
        /// Type of description : values: See Data Definition- description_type (normal , extended).
        /// </summary>
        [JsonProperty("description_type")]
        public string DescriptionType { get; set; }

        /// <summary>
        /// New description field. Only whitelist sellers can use it.
        /// </summary>
        [JsonProperty("description_info")]
        public ShopeeProductItemBaseInfoDescriptionModel DescriptionInfo { get; set; }
    }

    public class ShopeeProductItemBaseInfoModel:ShopeeBaseModel
    {
        [JsonProperty("warning")]
        public string Warning { get; set; }

        [JsonProperty("response")]
        public ShopeeProductItemBaseInfoResponseModel Response { get; set; }
    }


}
