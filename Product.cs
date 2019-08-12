using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Product
    {
        public string name;
        public int price;
        public int discount;
        public string category;
        public Product(string name,int price)
        {
            this.name = name;
            this.price = price;        
        }
    }
}
