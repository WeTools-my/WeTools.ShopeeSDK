using System.Collections.Generic;
using System.Text;
using WeTools.ShopeeSDK.Model;

namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeOrderAPI:ShopeeAPIBase
    {
        public ShopeeOrderAPI(ShopeeAPIBasic basic) 
        { 
            _basic = basic;
            ApiType = "order";
        }

        /// <summary>
        /// Use this api to search orders.
        /// https://open.shopee.com/documents?module=94&type=1&id=542&version=2
        /// </summary>
        /// <param name="time_range_field">The kind of time_from and time_to. Available value: create_time, update_time.</param>
        /// <param name="time_from">The time_from and time_to fields specify a date range for retrieving orders (based on the time_range_field). The time_from field is the starting date range. The maximum date range that may be specified with the time_from and time_to fields is 15 days.</param>
        /// <param name="time_to">The time_from and time_to fields specify a date range for retrieving orders (based on the time_range_field). The time_from field is the starting date range. The maximum date range that may be specified with the time_from and time_to fields is 15 days.</param>
        /// <param name="page_size">Each result set is returned as a page of entries. Use the "page_size" filters to control the maximum number of entries to retrieve per page (i.e., per call). This integer value is used to specify the maximum number of entries to return in a single "page" of data.The limit of page_size if between 1 and 100.</param>
        /// <param name="cursor">Specifies the starting entry of data to return in the current call. Default is "". If data is more than one page, the offset can be some entry to start next call.</param>
        /// <param name="order_status">The order_status filter for retriveing orders and each one only every request. Available value: UNPAID/READY_TO_SHIP/PROCESSED/SHIPPED/COMPLETED/IN_CANCEL/CANCELLED/INVOICE_PENDING</param>
        /// <param name="response_optional_fields">Optional fields in response. Available value: order_status.</param>
        /// <returns>ShopeeOrderListModel</returns>
        public ShopeeOrderListModel GetOrderList( long time_from, long time_to,int page_size, string cursor = "", string order_status = "", string time_range_field = "create_time",string response_optional_fields= "order_status")
        {
            string action = "get_order_list";
            var queryString = new StringBuilder();
            queryString.AppendFormat("&access_token={0}&shop_id={1}", _basic.AccessToken, _basic.ShopId);
            queryString.AppendFormat("&time_from={0}&page_size={1}&time_to={2}&time_range_field={3}&cursor={4}&response_optional_fields={5}", time_from, page_size,time_to, time_range_field,cursor, response_optional_fields);


            if (!string.IsNullOrWhiteSpace(order_status))
            {
                queryString.AppendFormat("&order_status={0}", order_status);
            }

            string url = GetRequestUrl(action, SignTypeEnum.Shop, queryString.ToString());
            string resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeOrderListModel>(resp);
        }

        /// <summary>
        /// Use this api to get order detail.
        /// https://open.shopee.com/documents?module=94&type=1&id=557&version=2
        /// </summary>
        /// <param name="order_sn_list">The set of order_sn. If there are multiple order_sn, you need to use English comma to connect them. limit [1,50]</param>
        /// <param name="response_optional_fields">Indicate response fields you want to get. Please select from the below response parameters. If you input an object field, all the params under it will be included automatically in the response. If there are multiple response fields you want to get, you need to use English comma to connect them. Available values: buyer_user_id,buyer_username,estimated_shipping_fee,recipient_address,actual_shipping_fee ,goods_to_declare,note,note_update_time,item_list,pay_time,dropshipper,dropshipper_phone,split_up,buyer_cancel_reason,cancel_by,cancel_reason,actual_shipping_fee_confirmed,buyer_cpf_id,fulfillment_flag,pickup_done_time,package_list,shipping_carrier,payment_method,total_amount,buyer_username,invoice_data, checkout_shipping_carrier, reverse_shipping_fee.</param>
        /// <returns>ShopeeOrderDetailListModel</returns>
        public ShopeeOrderDetailListModel GetOrderDetail(List<string> order_sn_list, List<string>? response_optional_fields = null)
        {
            string action = "get_order_detail";

            string orderSns = string.Join(",",order_sn_list);
            string fields = (response_optional_fields is null || response_optional_fields.Count<=0)
                ?"buyer_user_id,buyer_username,estimated_shipping_fee,recipient_address,actual_shipping_fee ,goods_to_declare,note,note_update_time,item_list,pay_time,dropshipper,dropshipper_phone,split_up,buyer_cancel_reason,cancel_by,cancel_reason,actual_shipping_fee_confirmed,buyer_cpf_id,fulfillment_flag,pickup_done_time,package_list,shipping_carrier,payment_method,total_amount,buyer_username,invoice_data, checkout_shipping_carrier, reverse_shipping_fee"
                :string.Join(",",response_optional_fields);
            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}&order_sn_list={orderSns}&response_optional_fields={fields}");
            string resp = _basic.Web.DoGet(url);

            return  ParseData<ShopeeOrderDetailListModel>(resp);
        }
    }
}
