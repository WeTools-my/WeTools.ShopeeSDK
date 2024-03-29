﻿namespace WeTools.ShopeeSDK.Util
{
    public class ShopeeAPI
    {
        public ShopeeAPI()
        {
        }

        private ShopeeShopAPI? _shop=null;
        private ShopeeProductAPI? _product=null;
        private ShopeeAuthAPI? _auth = null;
        private ShopeeShopCategoryAPI? _shopCategory=null;

        private ShopeeOrderAPI? _order=null;
        private ShopeeReturnAPI? _return=null;


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


        public ShopeeShopCategoryAPI? ShopCategory
        {
            get
            {
                if (_shopCategory is null)
                {
                    _shopCategory = new ShopeeShopCategoryAPI(Basic);
                }

                return _shopCategory;
            }
            set => _shopCategory = value;
        }

        public ShopeeOrderAPI? Order
        {
            get
            {
                if (_order is null)
                {
                    _order = new ShopeeOrderAPI(Basic);
                }

                return _order;
            }
            set => _order = value;
        }

        public ShopeeReturnAPI? Returns { get 
            {
                if (_return is null)
                {
                    _return = new ShopeeReturnAPI(Basic);
                }
                return _return;
            }
            set =>_return = value;
        }
    }
}
