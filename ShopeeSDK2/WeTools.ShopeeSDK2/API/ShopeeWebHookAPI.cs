using System;
using System.Collections.Generic;
using System.Text;
using WeTools.ShopeeSDK.Util;

namespace WeTools.ShopeeSDK.API
{
    public class ShopeeWebHookAPI : ShopeeAPIBase
    {
        public ShopeeWebHookAPI(ShopeePublicParams publicParams, WebUtils web) : base(publicParams, web)
        {
        }

        public bool VerifyPush(string url,string rawBody,string signature)
        {
            string baseStr = $"{url}|{rawBody}";

            string newSign = ShopeeUtils.AuthSignRequest(baseStr, _basic.PartnerKey);

            if (signature==newSign)
            {
                return true;
            }

            return false;
        }

        

    }
}
