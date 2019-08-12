using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Fashion
    {
        public int discount { get; set; }
        public List<string> list { get; set; }

        public Fashion()
        {
            list = new List<string>() {"Shirt","Jeans","Trouser","Chinos","Tshirt","Joggers","Blazzer","Sweater"};
            discount = 30;
        }
        public List<string> GetFashionItems()
        {
            return list;
        }
    }
}
