using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Home : ICategory
    {

       public int discount { get; set; }
       public List<string> list { get; set; }

        public Home()
        {
            list = new List<string>() { "Chair", "Table", "Bedsheets", "Bed", "Almirah", "Detergent" };
            discount = 10;            
        }

        public List<string> GetHomeItems()
        {
            return list;
        }
    }
}