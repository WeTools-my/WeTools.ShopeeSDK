using System.Collections.Generic;
using System.Text;
using WeTools.ShopeeSDK.Model;
using WeTools.ShopeeSDK.Util;

namespace WeTools.ShopeeSDK.API
{
    public class ShopeeProductAPI : ShopeeAPIBase
    {
        
        public ShopeeProductAPI(ShopeeBasicParams basicParams, WebUtils web) : base(basicParams, web)
        {
            ApiCategory = "product";
        }

        /// <summary>
        /// Use this call to get a list of items.
        /// https://open.shopee.com/documents?module=89&type=1&id=614&version=2
        /// </summary>
        /// <param name="offset">Specifies the starting entry of data to return in the current call. Default is 0. if data is more than one page, the offset can be some entry to start next call.</param>
        /// <param name="pageSize">the size of one page</param>
        /// <param name="updateTimeFrom">The update_time_from and update_time_to fields specify a date range for retrieving orders (based on the item update time). The update_time_from field is the starting date range.</param>
        /// <param name="updateTimeTo">The update_time_from and update_time_to fields specify a date range for retrieving orders (based on the item update time). The update_time_to field is the ending date range</param>
        /// <param name="itemStatus">NORMAL/BANNED/DELETED/UNLIST</param>
        /// <returns>ShopeeProductItemListModel</returns>
        public ShopeeProductGetItemListModel GetItemList(int offset, int pageSize, List<string> itemStatus, long updateTimeFrom = 0, long updateTimeTo = 0)
        {
            string action = "get_item_list";

            var queryString = new StringBuilder();
            queryString.AppendFormat("&offset={0}&page_size={1}", offset, pageSize);

            foreach (var item in itemStatus)
            {
                queryString.AppendFormat("&item_status={0}", item);
            }

            if (updateTimeFrom > 0)
            {
                queryString.AppendFormat("&update_time_from={0}", updateTimeFrom);
            }

            if (updateTimeTo > 0)
            {
                queryString.AppendFormat("&update_time_to={0}", updateTimeTo);
            }

            string url = GetRequestUrl(action, SignTypeEnum.Shop, queryString.ToString());
            string resp = _web.DoGet(url);

            return ParseData<ShopeeProductGetItemListModel>(resp);
        }
    }
}
