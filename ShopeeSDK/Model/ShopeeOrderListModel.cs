using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeTools.ShopeeSDK.Model
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ShopeeOrderBriefModel
    {
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }
    }

    public class ShopeeOrderListResponseModel
    {
        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        [JsonProperty("order_list")]
        public List<ShopeeOrderBriefModel> OrderList { get; set; }
    }

    public class ShopeeOrderListModel:ShopeeBaseModel
    {
        [JsonProperty("response")]
        public ShopeeOrderListResponseModel Response { get; set; }
    }


}
