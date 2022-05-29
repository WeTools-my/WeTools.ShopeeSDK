using System.Text;
using WeTools.ShopeeSDK.Model;

namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeShopCategoryAPI:ShopeeAPIBase
    {
        public ShopeeShopCategoryAPI(ShopeeAPIBasic basic)
        {
            ApiType = "shop_category";
            _basic = basic;
        }

        /// <summary>
        /// Use this call to get list of shop categories
        /// https://open.shopee.com/documents?module=101&type=1&id=587&version=2
        /// </summary>
        /// <param name="pageSize">Specifies the starting entry of data to return in the current call. The parameter range of page_size should be [1, 2147483647]</param>
        /// <param name="pageNo">Specifies the total returned data per entry. The parameter range of page_no should be [1, 100]</param>
        /// <returns></returns>
        public ShopeeShopCategoryListModel GetShopCategoryList(int pageSize,int pageNo)
        {
            string action = "get_shop_category_list";
            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}&page_size={pageSize}&page_no={pageNo}");

            var resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeShopCategoryListModel>(resp);
        }

        /// <summary>
        /// Use this call to get items list of certain shop_category
        /// https://open.shopee.com/documents?module=101&type=1&id=591&version=2
        /// </summary>
        /// <param name="shopCategoryId">ShopCategory's unique identifier.</param>
        /// <param name="pageSize">Specifies the starting entry of data to return in the current call. Default is 1000. The input range of page_size is [0, 1000]</param>
        /// <param name="pageNo">If many items are available to retrieve, you may need to call this api multiple times to retrieve all the data. And the default will be 0. page_size*page_no should be [0, 2147483446].</param>
        /// <returns></returns>
        public ShopeeShopCategoryItemModel GetItemList(long shopCategoryId, int pageSize, int pageNo)
        {
            string action = "get_item_list";

            var queryString = new StringBuilder();
            queryString.AppendFormat("&access_token={0}&shop_id={1}&shop_category_id={2}", _basic.AccessToken, _basic.ShopId, shopCategoryId);

            if (pageNo>0)
            {
                queryString.AppendFormat("&page_no={0}", pageNo);
            }

            if (pageSize > 0)
            {
                queryString.AppendFormat("&page_size={0}", pageSize);
            }

            string url = GetRequestUrl(action, SignTypeEnum.Shop, queryString.ToString());

            var resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeShopCategoryItemModel>(resp);
        }
    }
}
