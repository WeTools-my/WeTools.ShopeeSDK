using System.Collections.Generic;
using System.Text;
using WeTools.ShopeeSDK.Model;

namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeProductAPI:ShopeeAPIBase
    {

        public ShopeeProductAPI(ShopeeAPIBasic basic)
        {
            ApiType = "product";
            _basic = basic;
        }

        public string GetCategory(string language="en")
        {
            string action = "get_category";

            return "";
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
        public ShopeeProductItemListModel GetItemList(int offset,int pageSize, List<string> itemStatus, long updateTimeFrom=0,long updateTimeTo=0)
        {
            if (itemStatus ==null ||itemStatus.Count<=0 || pageSize<=0)
            {
                return new ShopeeProductItemListModel { Error = "parameters", Message = "Parameter is not valid" };
            }

            string action = "get_item_list";

            var queryString = new StringBuilder();
            queryString.AppendFormat("&access_token={0}&shop_id={1}", _basic.AccessToken, _basic.ShopId);
            queryString.AppendFormat("&offset={0}&page_size={1}",offset,pageSize);


            foreach (var item in itemStatus)
            {
                queryString.AppendFormat("&item_status={0}",item);
            }

            if (updateTimeFrom>0)
            {
                queryString.AppendFormat("&update_time_from={0}", updateTimeFrom);
            }

            if (updateTimeTo > 0)
            {
                queryString.AppendFormat("&update_time_to={0}", updateTimeTo);
            }

            string url = GetRequestUrl(action, SignTypeEnum.Shop, queryString.ToString());
            string resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeProductItemListModel>(resp);
        }

        /// <summary>
        /// Use this api to get basic info of item by item_id list.
        /// https://open.shopee.com/documents?module=89&type=1&id=612&version=2
        /// </summary>
        /// <param name="itemIds">item_id list; limit [0,50]</param>
        /// <param name="needTaxInfo">If true, will return tax info in response.</param>
        /// <param name="needComplaintPolicy">If true, will return complaint_policy in response.</param>
        /// <returns></returns>
        public ShopeeProductItemBaseInfoModel GetItemBaseInfo(List<long> itemIds,bool needTaxInfo=false,bool needComplaintPolicy=false)
        {
            if (itemIds == null || itemIds.Count <= 0)
            {
                return new ShopeeProductItemBaseInfoModel { Error = "parameters", Message = "Parameter is not valid" };
            }

            string action = "get_item_base_info";
            string ids=string.Join(",", itemIds);
            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={ _basic.ShopId}&need_tax_info={needTaxInfo}&need_complaint_policy={needComplaintPolicy}&item_id_list={ids}");

            string resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeProductItemBaseInfoModel>(resp);
        }

        /// <summary>
        /// Use this api to get extra info of item by item_id list.
        /// https://open.shopee.com/documents?module=89&type=1&id=613&version=2
        /// </summary>
        /// <param name="itemIds">item_id list, limit [0,50]</param>
        /// <returns></returns>
        public ShopeeProductItemExtraInfoModel GetItemExtraInfo(List<long> itemIds)
        {
            if (itemIds == null || itemIds.Count <= 0)
            {
                return new ShopeeProductItemExtraInfoModel { Error = "parameters", Message = "Parameter is not valid" };
            }

            string action = "get_item_extra_info";

            string ids = string.Join(",", itemIds);
            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={ _basic.ShopId}&item_id_list={ids}");

            string resp = _basic.Web.DoGet(url);

            return  ParseData<ShopeeProductItemExtraInfoModel>(resp);
        }

        /// <summary>
        /// Get model list of an item.
        /// https://open.shopee.com/documents?module=89&type=1&id=618&version=2
        /// </summary>
        /// <param name="itemId">The ID of the item</param>
        /// <returns></returns>
        public ShopeeProductItemModelModel GetModelList(long itemId)
        {
            if (itemId <= 0)
            {
                return new ShopeeProductItemModelModel { Error = "parameters", Message = "Parameter is not valid" };
            }
            string action = "get_model_list";
            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={ _basic.ShopId}&item_id={itemId}");

            string resp = _basic.Web.DoGet(url);

            return  ParseData<ShopeeProductItemModelModel>(resp);
        }

        /// <summary>
        /// Use this call to search item.
        /// https://open.shopee.com/documents?module=89&type=1&id=701&version=2
        /// </summary>
        /// <param name="offset">Specifies the starting entry of data to return in the current call. Default is empty. if data is more than one page, the offset can be some entry to start next call.</param>
        /// <param name="pageSize">the size of one page.</param>
        /// <param name="itemName">name of item.</param>
        /// <param name="attributeStatus">1:get item lack of requires attribute. 2:get item lack of optional attribute.</param>
        /// <returns></returns>
        public ShopeeProductItemSearchModel SearchItem(int pageSize,string itemName,int attributeStatus,string offset="")
        {
            if (string.IsNullOrWhiteSpace(itemName) || (attributeStatus!=1 && attributeStatus!=2) || pageSize <= 0)
            {
                return new ShopeeProductItemSearchModel { Error = "parameters", Message = "Parameter is not valid" };
            }

            string action = "search_item";
            var queryString = new StringBuilder();
            queryString.AppendFormat("&access_token={0}&shop_id={1}&page_size={2}", _basic.AccessToken, _basic.ShopId,pageSize);

            if (!string.IsNullOrWhiteSpace(offset))
            {
                queryString.AppendFormat("&offset={0}", offset);
            }
            
            if (!string.IsNullOrWhiteSpace(itemName))
            {
                queryString.AppendFormat("&item_name={0}", itemName);
            }

            if (attributeStatus==1||attributeStatus==2)
            {
                queryString.AppendFormat("&attribute_status={0}", attributeStatus);
            }

            string url = GetRequestUrl(action, SignTypeEnum.Shop, queryString.ToString());
            string resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeProductItemSearchModel>(resp);
        }

        /// <summary>
        /// update price
        /// https://open.shopee.com/documents?module=89&type=1&id=651&version=2
        /// </summary>
        /// <param name="itemId">ID of item.</param>
        /// <param name="priceList">Length should be between 1 to 50. model_id:0 for no model item. original_price:Original price for this model.</param>
        /// <returns>ShopeeProductUpdatePriceModel</returns>
        public ShopeeProductUpdatePriceModel UpdatePrice(long itemId,List<ShopeeProductUpdatePriceRequestModel> priceList)
        {
            if (itemId <= 0 ||priceList==null || priceList.Count<=0)
            {
                return new ShopeeProductUpdatePriceModel { Error = "parameters", Message = "Parameter is not valid" };
            }

            string action = "update_price";

            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}");

            var data = MakeData(new
            {
                item_id = itemId,
                price_list = priceList
            });

            var resp = _basic.Web.DoPost(url, data);

            return ParseData<ShopeeProductUpdatePriceModel>(resp);
        }


        /// <summary>
        /// Update stock.
        /// https://open.shopee.com/documents?module=89&type=1&id=652&version=2
        /// </summary>
        /// <param name="itemId">ID of item.</param>
        /// <param name="stockList">Length should be between 1 to 50. model_id:0 for no model item. normal_stock:Normal stock.</param>
        /// <returns>ShopeeProductUpdateStockModel</returns>
        public ShopeeProductUpdateStockModel UpdateStock(long itemId, List<ShopeeProductUpdateStockRequestModel> stockList)
        {
            if (itemId <= 0 || stockList == null || stockList.Count <= 0)
            {
                return new ShopeeProductUpdateStockModel { Error = "parameters", Message = "Parameter is not valid" };
            }

            string action = "update_stock";

            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}");

            var data = MakeData(new
            {
                item_id = itemId,
                stock_list = stockList
            });

            var resp = _basic.Web.DoPost(url, data);

            return ParseData<ShopeeProductUpdateStockModel>(resp);
        }

        /// <summary>
        /// Use this api to get comment by shop_id, item_id, or comment_id.
        /// </summary>
        /// <see href="https://open.shopee.com/documents?module=89&type=1&id=562&version=2">document</see>
        /// <param name="page_size">Each result set is returned as a page of entries. Use the "page_size" filters to control the maximum number of entries to retrieve per page (i.e., per call). This integer value is used to specify the maximum number of entries to return in a single "page" of data. The limit of page_size if between 1 and 100.</param>
        /// <param name="cursor">Specifies the starting entry of data to return in the current call. Default is "". If data is more than one page, the offset can be some entry to start next call.</param>
        /// <param name="item_id">The identity of product item.</param>
        /// <param name="comment_id">The identity of comment.</param>
        /// <returns></returns>
        public ShopeeProductCommentListModel GetComment(int page_size,string cursor="",long item_id=0,long comment_id=0)
        {
            string action = "get_comment";
            var queryString = new StringBuilder();
            queryString.AppendFormat("&access_token={0}&shop_id={1}&page_size={2}", _basic.AccessToken, _basic.ShopId, page_size);

            if (!string.IsNullOrWhiteSpace(cursor))
            {
                queryString.AppendFormat("&cursor={0}", cursor);
            }

            if (item_id>0)
            {
                queryString.AppendFormat("&item_id={0}", item_id);
            }

            if (comment_id>0)
            {
                queryString.AppendFormat("&comment_id={0}", comment_id);
            }

            string url = GetRequestUrl(action, SignTypeEnum.Shop, queryString.ToString());
            string resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeProductCommentListModel>(resp);
        }

        public (ShopeeProductCommentReplyResultModel,string) ReplyComment(List<ShopeeProductCommentReplyModel> commentList)
        {
            string action = "reply_comment";
            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}");

            var data = MakeData(new
            {
                comment_list = commentList
            });

            var resp = _basic.Web.DoPost(url, data);

            return (ParseData<ShopeeProductCommentReplyResultModel>(resp),resp);
        }

    }
}
