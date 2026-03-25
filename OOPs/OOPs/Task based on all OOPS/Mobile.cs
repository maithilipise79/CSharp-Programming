using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public class Mobile
    {
        public string Brand {  get; set; }
        public double Price {  get; set; }

        public Mobile()
        {
            Brand = "IPhone 14 Pro Max";
            Price = 65000;
        }
        public Mobile(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Brand : {Brand} ,Price : {Price}");
        }

    }
}
