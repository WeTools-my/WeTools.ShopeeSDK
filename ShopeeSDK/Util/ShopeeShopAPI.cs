using WeTools.ShopeeSDK.Model;

namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeShopAPI:ShopeeAPIBase
    {
        public ShopeeShopAPI(ShopeeAPIBasic basic)
        {
            ApiType = "shop";
            _basic = basic;
        }

        /// <summary>
        /// Use this call to get information of shop
        /// </summary>
        /// <returns>ShopeeShopInfoModel</returns>
        public ShopeeShopInfoModel GetShopInfo()
        {
            string action = "get_shop_info";
            string url= GetRequestUrl(action,SignTypeEnum.Shop,$"&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}");
            string resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeShopInfoModel>(resp);
        }

        /// <summary>
        /// This API support to get information of shop.
        /// </summary>
        /// <returns>ShopeeShopProfileModel</returns>
        public ShopeeShopProfileModel GetProfile()
        {
            string action = "get_profile";
            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}");
            string resp = _basic.Web.DoGet(url);

            return ParseData<ShopeeShopProfileModel>(resp);
        }

        /// <summary>
        /// This API support to let sellers to update the shop name, shop logo, and shop description.
        /// </summary>
        /// <param name="shopName">The new shop name</param>
        /// <param name="shopLogo">The new shop logo url. Recommend to use images</param>
        /// <param name="description">The new shop description.</param>
        /// <returns>ShopeeShopProfileModel</returns>
        public ShopeeShopProfileModel UpdateProfile(string shopName,string shopLogo,string description)
        {
            string action = "update_profile";
            string url = GetRequestUrl(action, SignTypeEnum.Shop, $"&access_token={_basic.AccessToken}&shop_id={_basic.ShopId}");

            var data = MakeData(new
            {
                shop_name=shopName,
                shop_logo = shopLogo,
                description = description
            });

            var resp = _basic.Web.DoPost(url, data);
            return ParseData<ShopeeShopProfileModel>(resp);
        }

        /// <summary>
        /// Shop Authorization
        /// Expiration and Operation Timeout Logic:
        ///The authorization url expires in 5 minutes(because of timestamp expiration), after which developers have to generate a new one.
        ///After clicking in the authorization url, shop owners will have 3 minutes to enter the shop account or main account username & password.If they don't finish in time, it will return an “operation overtime” error when they submit and they need to re-open the url(instead of refreshing the page).
        ///Retrieve code and shop_id or main_account_id:
        ///# code and shop_id or main_account_id show in the redirect url after the authorization is completed 
        ///A notice with partner_id and shop_id or main_account_id will be sent to developer’s registered email(not applicable in test environment)
        /// </summary>
        /// <param name="redirectUrl">Redirect Url</param>
        /// <returns>Authorization url</returns>
        public string Auth(string redirectUrl)
        {
            string action = "auth_partner";
            var url = GetRequestUrl(action,$"&redirect={redirectUrl}");
            return url;
        }

        /// <summary>
        ///Cancel Shop Authorization
        /// </summary>
        /// <param name="redirectUrl">Redirect Url</param>
        /// <returns>Cancel Authorization url</returns>
        public string CancelAuth(string redirectUrl)
        { 
            string action = "cancel_auth_partner";
            var url = GetRequestUrl(action, $"&redirect={redirectUrl}");
            return url;
        }

    }
}
