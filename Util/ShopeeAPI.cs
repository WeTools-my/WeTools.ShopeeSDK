namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeAPI
    {
        public ShopeeAPI()
        {
        }

        private ShopeeShopAPI? _shop=null;
        private ShopeeProductAPI? _product=null;
        private ShopeeAuthAPI? _auth = null;

        public ShopeeAPIBasic? Basic { get; set; }

        public ShopeeShopAPI? Shop
        {
            get
            {
                if (_shop is null)
                {
                    _shop = new ShopeeShopAPI(Basic);
                }

                return _shop;
            }
            set => _shop = value;
        }

        public ShopeeProductAPI? Product {
            get
            {
                if (_product is null )
                {
                    _product = new ShopeeProductAPI(Basic);
                }

                return _product;
            }
            set => _product = value;
        }

        public ShopeeAuthAPI? Auth
        {
            get
            {
                if (_auth is null)
                {
                    _auth = new ShopeeAuthAPI(Basic);
                }

                return _auth;
            }
            set => _auth = value;
        }

    }
}
