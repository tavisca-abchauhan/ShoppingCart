using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Items
    {
        List<Product> ItemsAvailableForPurchase;
        
        public Items()
        {
            ItemsAvailableForPurchase = new List<Product>();
                      
        }
        public void AddItems(Product product)
        {
            //Product product = new Product(name, price);
           // Console.WriteLine("item added");
            //if(FashionList.Contains(product.name))
            ItemsAvailableForPurchase.Add(product);
           // Console.WriteLine(ItemsAvailableForPurchase.Count);
        }
        public List<Product> GetItemsAvailableForPurchase()
        {
            return ItemsAvailableForPurchase;
        }
    }
}
