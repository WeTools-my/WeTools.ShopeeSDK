using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ShopeeProductItemModelImageModel
    {
        [JsonProperty("image_id")]
        public string ImageId { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class ShopeeProductItemModelOptionListModel
    {
        [JsonProperty("option")]
        public string Option { get; set; }

        [JsonProperty("image")]
        public ShopeeProductItemModelImageModel Image { get; set; }
    }

    public class ShopeeProductItemModelTierVariationModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("option_list")]
        public List<ShopeeProductItemModelOptionListModel> OptionList { get; set; }
    }

    public class ShopeeProductItemModelStockInfoModel
    {
        [JsonProperty("stock_type")]
        public int StockType { get; set; }

        [JsonProperty("current_stock")]
        public int CurrentStock { get; set; }

        [JsonProperty("normal_stock")]
        public int NormalStock { get; set; }

        [JsonProperty("reserved_stock")]
        public int ReservedStock { get; set; }
    }

    public class ShopeeProductItemModelPriceInfoModel
    {
        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }

        [JsonProperty("original_price")]
        public decimal OriginalPrice { get; set; }

        [JsonProperty("inflated_price_of_current_price")]
        public decimal InflatedPriceOfCurrentPrice { get; set; }

        [JsonProperty("inflated_price_of_original_price")]
        public decimal InflatedPriceOfOriginalPrice { get; set; }

        [JsonProperty("sip_item_price")]
        public decimal SipItemPrice { get; set; }

        [JsonProperty("sip_item_price_source")]
        public string SipItemPriceSource { get; set; }
    }

    public class ShopeeProductItemModelPreOrderModel
    {
        [JsonProperty("is_pre_order")]
        public bool IsPreOrder { get; set; }

        [JsonProperty("days_to_ship")]
        public int DaysToShip { get; set; }
    }

    public class ShopeeProductItemModelInfoModel
    {
        [JsonProperty("model_id")]
        public long ModelId { get; set; }

        [JsonProperty("promotion_id")]
        public long PromotionId { get; set; }

        [JsonProperty("tier_index")]
        public List<int> TierIndex { get; set; }

        [JsonProperty("stock_info")]
        public List<ShopeeProductItemModelStockInfoModel> StockInfo { get; set; }

        [JsonProperty("price_info")]
        public List<ShopeeProductItemModelPriceInfoModel> PriceInfo { get; set; }

        [JsonProperty("model_sku")]
        public string ModelSku { get; set; }

        [JsonProperty("pre_order")]
        public ShopeeProductItemModelPreOrderModel PreOrder { get; set; }
    }

    public class ShopeeProductItemModelResponseModel
    {
        [JsonProperty("tier_variation")]
        public List<ShopeeProductItemModelTierVariationModel> TierVariation { get; set; }

        [JsonProperty("model")]
        public List<ShopeeProductItemModelInfoModel> Model { get; set; }
    }

    public class ShopeeProductItemModelModel:ShopeeBaseModel
    {

        [JsonProperty("response")]
        public ShopeeProductItemModelResponseModel Response { get; set; }
    }


}
