using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Items item = new Items();           
            Product product1= new Product("Jeans",800);
            Product product2= new Product("Shirt",700);
            Product product3= new Product("Chinos",750);
            Product product4= new Product("Tshirt", 500);
            Product product5 = new Product("Facewash", 250);
            Product product6 = new Product("Mobile", 15000);
            item.AddItems(product1);
            item.AddItems(product2);
            item.AddItems(product3);
            item.AddItems(product4);
            item.AddItems(product5);
            item.AddItems(product6);
            Cart cart = new Cart(item);
            cart.AddProductToCart(product1, 2);
            cart.AddProductToCart(product2, 4);
            cart.AddProductToCart(product6, 1);
            Amount amount1 = new Amount(10,cart);
            Amount amount2 = new Amount(cart);
            Console.WriteLine(amount1.GetFinalAmount());

            Console.WriteLine(amount2.GetFinalAmount());
            Console.ReadKey(true);

        }
    }
}
