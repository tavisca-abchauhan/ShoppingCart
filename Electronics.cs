using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Electronics
    {
        public int discount { get; set; }
        public List<string> list { get; set; }

        public Electronics()
        {
            list = new List<string>() { "Mobile","Refrigerator","Toaster","Oven","Laptops","Television" };
            discount = 25;
        }

        public List<string> GetElectronicsItems()
        {
            return list;
        }
    }
}
