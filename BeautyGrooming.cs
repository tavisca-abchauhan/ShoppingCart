using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class BeautyGrooming
    {
        public int discount { get; set; }
        public List<string> list { get; set; }

        public BeautyGrooming()
        {
            list = new List<string>() {"Oil","Perfume","Soap","BodyWash","Facewash","FaceMask","Lotion","Cream"};
            discount = 15;
        }

        public List<string> GetBeautyGroomingItems()
        {
            return list;
        }
    }
}
