using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Cart
    {
        public Dictionary<Product, int> ProductInCart = new Dictionary<Product, int>();
        List<Product> ItemsAvailable;

        List<string> FashionList;
        List<string> HomeList;
        List<string> ElectronicsList;
        List<string> BeautyProductsList;
        Fashion fashion;
        Home home;
        Electronics electronics;
        BeautyGrooming beauty;

        public Dictionary<Product, int> CategoryDiscount = new Dictionary<Product, int>();

        public Cart()
        {
            
        }
        public Cart(Items item)
        {
            ItemsAvailable = item.GetItemsAvailableForPurchase();
            fashion = new Fashion();
            home = new Home();
            electronics = new Electronics();
            beauty = new BeautyGrooming();
            FashionList = fashion.GetFashionItems();
            HomeList = home.GetHomeItems();
            ElectronicsList = electronics.GetElectronicsItems();
            BeautyProductsList = beauty.GetBeautyGroomingItems();
            //Console.WriteLine("cart"+ItemsAvailable.Count);
        }
        public void AddProductToCart(Product product,int quantity)
        {
            // Console.WriteLine("Fashion List Count " + fashion.GetFashionItems().Count);
            if (FashionList.Contains(product.name))
            {
                product.category = "Fashion";
                product.discount = fashion.discount;
            }
            if (HomeList.Contains(product.name))
            {
                product.category = "Home";
                product.discount = fashion.discount;
            }
            if (ElectronicsList.Contains(product.name))
            {
                product.category = "Electronics";
                product.discount = fashion.discount;
            }
            if (BeautyProductsList.Contains(product.name))
            {
                product.category = "Beauty";
                product.discount = fashion.discount;
            }

            if (ItemsAvailable.Contains(product))
            {
                if (ProductInCart.ContainsKey(product))
                {
                    var updatedQuantity = ProductInCart[product] + quantity;
                    ProductInCart[product] = updatedQuantity;
                }
                else
                {
                    ProductInCart.Add(product, quantity);
                    
                }
            }
        }
        public void RemoveProductFromCart(Product product, int quantity)
        {
            if (ProductInCart.ContainsKey(product))
            {
                var updatedQuantity = ProductInCart[product] - quantity;

                if (updatedQuantity <= 0)
                {
                    ProductInCart.Remove(product);
                }
                else
                {
                    ProductInCart[product] = updatedQuantity;
                }
            }
        }
        public Dictionary<Product, int> GetCartList()
        {
            return ProductInCart;
        }
    }
}
