using WeTools.ShopeeSDK.Model;
using WeTools.ShopeeSDK.Util;

namespace WeTools.ShopeeSDK.API
{
    public class ShopeeAuthAPI : ShopeeAPIBase
    {
        public ShopeeAuthAPI(ShopeeBasicParams basicParams, WebUtils web) : base(basicParams, web)
        {
            ApiCategory = "auth";
        }

        public ShopeeAccesstokenModel GetAccesstoken(string code, long shopId, long mainAccountId = 0)
        {

            string action = "token/get";
            string url = GetRequestUrl(action);

            string data;
            if (mainAccountId == 0)
            {
                data = MakeData(new
                {
                    code,
                    partner_id = _basic.PartnerId,
                    shop_id = shopId
                });
            }
            else
            {
                data = MakeData(new
                {
                    code,
                    partner_id = _basic.PartnerId,
                    shop_id = shopId,
                    main_account_id = mainAccountId
                });
            }

            var resp = _web.DoPost(url, data);

            return ParseData<ShopeeAccesstokenModel>(resp);
        }

        public ShopeeAccesstokenModel GetRefreshAccessToken(string refreshToken, long shopId = 0, long merchantId = 0)
        {
            if (string.IsNullOrWhiteSpace(refreshToken) || (shopId == 0 && merchantId == 0) || (shopId != 0 && merchantId != 0))
            {
                return new ShopeeAccesstokenModel { Error = "parameters", Message = "Parameter is not valid" };
            }

            string action = "access_token/get";
            string url = GetRequestUrl(action);
            string data = null;

            if (shopId > 0)
            {
                data = MakeData(new
                {
                    refresh_token = refreshToken,
                    partner_id = _basic.PartnerId,
                    shop_id = shopId
                });
            }

            if (merchantId > 0)
            {
                data = MakeData(new
                {
                    refresh_token = refreshToken,
                    partner_id = _basic.PartnerId,
                    merchant_id = merchantId
                });
            }

            var resp = _web.DoPost(url, data);

            return ParseData<ShopeeAccesstokenModel>(resp);
        }
    }
}
