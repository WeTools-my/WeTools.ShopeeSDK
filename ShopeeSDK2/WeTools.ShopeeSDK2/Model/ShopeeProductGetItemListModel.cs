using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeTools.ShopeeSDK.Model
{
    public class ShopeeProductGetItemListModel : ShopeeBaseModel
    {
        public ShopeeProductGetItemListResponse Response { get; set; }
    }

    public class ShopeeProductGetItemListResponse
    {
        [JsonProperty(PropertyName = "total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// This is to indicate whether the item list is more than one page. If this value is true, you may want to continue to check next page to retrieve the rest of items.
        /// </summary>
        [JsonProperty(PropertyName = "has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// if has_next_page is true, this value need set to next request.offset
        /// </summary>
        [JsonProperty(PropertyName = "next_offset")]
        public int NextOffset { get; set; }

        public List<ShopeeProductItem> Item { get; set; }
    }

    public class ShopeeProductItem
    {
        [JsonProperty(PropertyName = "item_id")]
        public long ItemId { get; set; }

        [JsonProperty(PropertyName = "item_status")]
        public string ItemStatus { get; set; }

        [JsonProperty(PropertyName = "update_time")]
        public long UpdateTime { get; set; }
    }
}
