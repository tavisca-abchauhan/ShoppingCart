using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Amount
    {
        int discount=-1;
        Cart cart;
        public Amount(int discount,Cart cart)
        {
            this.discount = discount;
            this.cart = cart;
        }
        public Amount(Cart cart)
        {
            this.cart = cart;
        }
        


        public int GetFinalAmount()
        {
            Dictionary<Product, int> ItemsToBePurchased = cart.GetCartList();
            int totalamount = 0;
            if (discount != -1)
            {
                foreach (KeyValuePair<Product, int> item in ItemsToBePurchased)
                {
                    // Console.WriteLine(item.Key.name + "  " + item.Key.category);
                    totalamount += item.Key.price * item.Value;
                }
                totalamount = totalamount - ((totalamount * discount) / 100);
            }
            else
            {
                foreach (KeyValuePair<Product, int> item in ItemsToBePurchased)
                {
                    // Console.WriteLine(item.Key.name + "  " + item.Key.category);
                    totalamount += (item.Key.price * item.Value)-(item.Key.price * item.Value*item.Key.discount)/100;
                }
            }
            return totalamount;
        }
    }
}
