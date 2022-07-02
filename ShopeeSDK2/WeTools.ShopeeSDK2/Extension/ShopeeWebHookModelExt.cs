using WeTools.ShopeeSDK.Model;

namespace WeTools.ShopeeSDK.Extension
{
    public static class  ShopeeWebHookModelExt
    {
        public static ShopeeWebHookTestModel GetTestPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookTestModel>();
        }
        public static ShopeeWebHookOrderStatusModel GetOrderStatusPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookOrderStatusModel>();
        }

        public static ShopeeWebHookAuthModel GetAuthorizationPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookAuthModel>();
        }

        public static ShopeeWebHookAuthModel GetDeAuthorizationPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookAuthModel>();
        }

        public static ShopeeWebHookTrackingNoModel GetTrackingNoPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookTrackingNoModel>();
        }

        public static ShopeeWebHookShopeeUpdateModel GetShopeeUpdatePush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookShopeeUpdateModel>();
        }

        public static ShopeeWebHookBannedItemModel GetBannedItemPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookBannedItemModel>();
        }

        public static ShopeeWebHookItemPromotionModel GetItemPromotionPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookItemPromotionModel>();
        }

        public static ShopeeWebHookReservedStockModel GetReservedStockChangePush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookReservedStockModel>();
        }

        public static ShopeeWebHookItemPromotionModel GetPromotionUpdatePush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookItemPromotionModel>();
        }

        public static ShopeeWebHookWebChatModel GetWebchatPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookWebChatModel>();
        }

        public static ShopeeWebHookVideoModel GetVideoUploadPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookVideoModel>();
        }

        public static ShopeeWebHookTokenExpiryModel GetAuthorizationExpiryPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookTokenExpiryModel>();
        }

        public static ShopeeWebHookBrandRegisterModel GetBrandRegisterPush(this ShopeeWebHookBaseModel baseModel)
        {
            return baseModel.GetModel<ShopeeWebHookBrandRegisterModel>();
        }
    }
}
