using System.Text;
using WeTools.ShopeeSDK.Model;

namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeReturnAPI : ShopeeAPIBase
    {
        public ShopeeReturnAPI(ShopeeAPIBasic basic)
        {
            _basic = basic;
            ApiType = "returns";
        }

        /// <summary>
        /// Use this api to get detail information of many return by shop id.
        /// https://open.shopee.com/documents/v2/v2.returns.get_return_list?module=102&type=1
        /// </summary>
        /// <param name="page_no">Specifies the starting entry of data to return in the current call. Default is 0. if data is more than one page, the offset can be some entry to start next call.</param>
        /// <param name="page_size">if many items are available to retrieve, you may need to call GetReturnList multiple times to retrieve all the data. Each result set is returned as a page of entries. Default is 40. Use the Pagination filters to control the maximum number of entries (<= 100) to retrieve per page (i.e., per call), the offset number to start next call. This integer value is usUed to specify the maximum number of entries to return in a single ""page"" of data.</param>
        /// <param name="create_time_from">The create_time_from and create_time_to fields specify a date range for retrieving orders (based on the order create time). The create_time_from field is the starting date range. The maximum date range that may be specified with the create_time_from and create_time_to fields is 15 days.</param>
        /// <param name="create_time_to">The create_time_from and create_time_to fields specify a date range for retrieving orders (based on the order create time). The create_time_from field is the starting date range. The maximum date range that may be specified with the create_time_from and create_time_to fields is 15 days.</param>
        /// <param name="status">This is for filtering return request by return status. See "Data Definition - ReturnStatus"</param>
        /// <param name="negotiation_status">This is for filtering return request by return status. See "Data Definition - ReturnStatus"</param>
        /// <param name="seller_proof_status">This is for filtering return request by proof status. See "Data Definition - SellerProofStatus"</param>
        /// <param name="seller_compensation_status">This is for filtering return request by proof status. See "Data Definition - SellerProofStatus"</param>
        /// <returns>ShopeeReturnListModel</returns>
        public ShopeeReturnListModel GetReturnList(int page_no, int page_size, long create_time_from=0,long create_time_to=0,string? status =null,string? negotiation_status=null,string? seller_proof_status=null,string? seller_compensation_status=null)
        {
            string action = "get_return_list";
            var queryString = new StringBuilder();
            queryString.AppendFormat("&access_token={0}&shop_id={1}", _basic.AccessToken, _basic.ShopId);
            queryString.AppendFormat("&page_no={0}&page_size={1}", page_no, page_size);

            if (create_time_from>0)
            {
                queryString.AppendFormat("&create_time_from={0}", create_time_from);
            }

            if (create_time_to > 0)
            {
                queryString.AppendFormat("&create_time_to={0}", create_time_to);
            }

            if (!string.IsNullOrWhiteSpace(status))
            {
                queryString.AppendFormat("&status={0}", status);
            }

            if (!string.IsNullOrWhiteSpace(negotiation_status))
            {
                queryString.AppendFormat("&negotiation_status={0}", negotiation_status);
            }

            if (!string.IsNullOrWhiteSpace(seller_proof_status))
            {
                queryString.AppendFormat("&seller_proof_status={0}", seller_proof_status);
            }

            if (!string.IsNullOrWhiteSpace(seller_compensation_status))
            {
                queryString.AppendFormat("&seller_compensation_status={0}", seller_compensation_status);
            }

            string url = GetRequestUrl(action, SignTypeEnum.Shop, queryString.ToString());
            string resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeReturnListModel>(resp);
        }
    }
}
