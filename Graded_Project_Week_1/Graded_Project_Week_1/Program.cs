using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Project_Week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer stored
            List<ShoppingCart> previous_visit_shoppingcart = new List<ShoppingCart>()
            {
                new ShoppingCart("pan", "milton", 1299, "black steel pan"),
                new ShoppingCart("induction", "prestige", 2999, "model 2.9"),
                new ShoppingCart("pressure cooker", "hawkins", 999, "stainless steel model 9.0")
            };
            SortByPrice sortbyprice = new SortByPrice();
            previous_visit_shoppingcart.Sort(sortbyprice);
            int total_price = 0;
            foreach (var item in previous_visit_shoppingcart)
            {
                total_price += item.price();
            }

            //Adding customers
            Customer customer = new Customer("yash", 9090909090, "ballarpur");

            Console.WriteLine("Customer's Details:");
            Console.WriteLine("-------------------");
            customer.Display();

            if (customer.CustomerName == "yash" & customer.CustomerPhoneNo == 9090909090 & customer.CustomerAddress == "ballarpur")
            {
                Console.WriteLine("\n \nCustomer History (Previous Visit Details):");
                Console.WriteLine("------------------------------------");
                foreach (ShoppingCart item in previous_visit_shoppingcart)
                {
                    item.Display();
                }
                Console.WriteLine($"\nCustomer Previous Paided Bill: {total_price} Rs.");
            }
            else
            {
                Console.WriteLine("\n \nCustomer visited first time.");
            }

            //Customer friend
            Customer customer_friend = new Customer("pradeep", 787878787878, "jaipur");

            //Adding Items to Shopping Cart            
            List<ShoppingCart> shoppingcart = new List<ShoppingCart>();
            shoppingcart.Add(new ShoppingCart("bag", "skybag", 1299, "college laptop bag"));
            shoppingcart.Add(new ShoppingCart("bottle", "milton", 899, "steel water bottle"));
            shoppingcart.Add(new ShoppingCart("pen", "cello", 20, "blue pen"));
            shoppingcart.Add(new ShoppingCart("notebook", "atlas", 50, "a4 size page"));

            List<ShoppingCart> shoppingcart_friend = new List<ShoppingCart>();
            shoppingcart_friend.Add(new ShoppingCart("milk", "amol", 79, "1 liter bottle", customer_friend));
            shoppingcart_friend.Add(new ShoppingCart("butter", "britannia", 19, "10 gram", customer_friend));
            shoppingcart_friend.Add(new ShoppingCart("panner", "amol", 150, "750 gram", customer_friend));
            shoppingcart_friend.Add(new ShoppingCart("panner masala", "suhana", 45, "100 gram", customer_friend));

            //Sorting w.r.t Price
            shoppingcart.Sort(sortbyprice);

            //Display all Items from Shopping Cart
            Console.WriteLine("\n \nCustomer's Shopping Cart Details:");
            Console.WriteLine("---------------------------------");
            foreach (ShoppingCart item in shoppingcart)
            {
                item.Display();
            }

            //Toal price to pay
            total_price = 0;
            foreach (var item in shoppingcart)
            {
                total_price += item.price();
            }
            int customer_bill = total_price;
            Console.WriteLine("\n \n---------------");
            Console.WriteLine($"Customer Bill: {total_price} Rs.");
            Console.WriteLine("---------------");

            Console.WriteLine("\n \nDo customer want to pay for his/her friends bill (y/n)?: ");
            string ans = Console.ReadLine();

            if (ans == "y")
            {
                Console.WriteLine("\n \nCustomer Friends Details:");
                Console.WriteLine("-------------------------");
                customer_friend.Display();

                //SortByPrice gg_f = new SortByPrice();
                shoppingcart_friend.Sort(sortbyprice);

                Console.WriteLine("\n \nCustomer Friend Shopping Cart Details:");
                Console.WriteLine("--------------------------------------");
                foreach (ShoppingCart item in shoppingcart_friend)
                {
                    item.Display();
                }

                foreach (var item in shoppingcart_friend)
                {
                    total_price += item.price();
                }

                Console.WriteLine("\n \n----------------------");
                Console.WriteLine($"Customer Friends Bill: {total_price - customer_bill} Rs.");
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("\n \n-----------");
            Console.WriteLine($"Total Bill: {total_price} Rs.");
            Console.WriteLine("-----------");

            Console.Read();
        }
    }
}
