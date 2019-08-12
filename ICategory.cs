using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public  interface ICategory
    {
        List<string> list { get; set; }
        int discount { get; set; }
    }
}
