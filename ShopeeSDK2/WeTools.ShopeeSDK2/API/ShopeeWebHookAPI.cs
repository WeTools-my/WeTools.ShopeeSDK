using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeTools.ShopeeSDK.Model;
using WeTools.ShopeeSDK.Util;

namespace WeTools.ShopeeSDK.API
{
    public class ShopeeWebHookAPI : ShopeeAPIBase
    {
        public ShopeeWebHookAPI(ShopeeBasicParams basicParams) : base(basicParams)
        {
        }

        public bool Verify(string url,string rawBody,string signature)
        {
            string baseStr = $"{url}|{rawBody}";

            string newSign = ShopeeUtils.AuthSignRequest(baseStr, _basic.PartnerKey);
            //System.Console.WriteLine($"New sign:{newSign}");
            return signature.Equals(newSign);
        }

        public ShopeeWebHookBaseModel Parse(string json)
        {
            JObject model = (JObject)JsonConvert.DeserializeObject(json);
            var baseModel=model.ToObject<ShopeeWebHookBaseModel>(); 
            baseModel.ModelObject = model;

            return baseModel;
        }

        public ShopeeWebHookTestModel GetTestPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookTestModel>();
        }
        public ShopeeWebHookOrderStatusModel GetOrderStatusPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookOrderStatusModel>();
        }

        public ShopeeWebHookAuthModel GetAuthorizationPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookAuthModel>();
        }

        public ShopeeWebHookAuthModel GetDeAuthorizationPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookAuthModel>();
        }

        public ShopeeWebHookTrackingNoModel GetTrackingNoPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookTrackingNoModel>();
        }

        public ShopeeWebHookShopeeUpdateModel GetShopeeUpdatePush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookShopeeUpdateModel>();
        }

        public ShopeeWebHookBannedItemModel GetBannedItemPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookBannedItemModel>();
        }

        public ShopeeWebHookItemPromotionModel GetItemPromotionPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookItemPromotionModel>();
        }

        public ShopeeWebHookReservedStockModel GetReservedStockChangePush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookReservedStockModel>();
        }

        public ShopeeWebHookItemPromotionModel GetPromotionUpdatePush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookItemPromotionModel>();
        }

        public ShopeeWebHookWebChatModel GetWebchatPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookWebChatModel>();
        }

        public ShopeeWebHookVideoModel GetVideoUploadPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookVideoModel>();
        }

        public ShopeeWebHookTokenExpiryModel GetAuthorizationExpiryPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookTokenExpiryModel>();
        }

        public ShopeeWebHookBrandRegisterModel GetBrandRegisterPush(ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookBrandRegisterModel>();
        }
    }
}
