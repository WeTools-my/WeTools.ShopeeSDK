using System.ComponentModel;

namespace WeTools.ShopeeSDK.Model
{
    public enum ShopeeWebHookCode
    {
        [Description("Test callback url")]
        Test,
        [Description("Shop authorization for partners")]
        Auth,
        [Description("Shop deauthorization for partners")]
        DeAuth,
        [Description("Order status update push")]
        OrderStatus,
        [Description("Tracking No push")]
        TrackingNo,
        [Description("Shopee updates")]
        ShopeeUpdate,
        [Description("Banned Item Push")]
        Banned,
        [Description("Item Promotion Push")]
        ItemPromotion,
        [Description("Reserved Stock Change Push")]
        ReservedStock,
        [Description("Promotion Update Push")]
        Promotion,
        [Description("WebChat Push")]
        WebChat,
        [Description("Video Upload Push")]
        Video,
        [Description("OpenAPI Authorization Expiry Push")]
        TokenExpiry,
        [Description("Brand Register Result")]
        BrandRegister
    }
}
