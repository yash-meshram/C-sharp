using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Project_Week_1
{
    internal class Customer
    {
        public string CustomerName;
        public long CustomerPhoneNo;
        public string CustomerAddress;
        public Customer(string CustomerName, long CustomerPhoneNo, string CustomerAddress)
        {
            this.CustomerName = CustomerName;
            this.CustomerPhoneNo = CustomerPhoneNo;
            this.CustomerAddress = CustomerAddress;
        }
        public void Display()
        {
            Console.WriteLine($"{CustomerName}, {CustomerPhoneNo}, {CustomerAddress}");
        }
    }
    class ShoppingCart
    {
        public string ItemName;
        public string BrandName;
        public int Price;
        public string Description;
        Customer customer;
        public ShoppingCart(string ItemName, string BrandName, int Price, string Description)
        {
            this.ItemName = ItemName;
            this.BrandName = BrandName;
            this.Price = Price;
            this.Description = Description;
        }
        public ShoppingCart(string ItemName, string BrandName, int Price, string Description, Customer customer)
        {
            this.ItemName = ItemName;
            this.BrandName = BrandName;
            this.Price = Price;
            this.Description = Description;
            this.customer = customer;
        }
        public void Display()
        {
            Console.WriteLine($"{ItemName}, {BrandName}, {Price}, {Description}");
        }
        public int price()
        {
            return Price;
        }
    }

    class SortByPrice : IComparer<ShoppingCart>
    {
        public int Compare(ShoppingCart x, ShoppingCart y)
        {
            return x.price().CompareTo(y.price());
        }
    }
}
