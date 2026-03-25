using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int RAM { get; set; }

        public Laptop() { }
        public Laptop(int id, string name, double price, int rAM )
        {
            Id = id;
            Name = name;
            Price = price;
            RAM = rAM;
        }

        public override string ToString()
        {
            return $"Id :{Id} , Name :{Name} , Price :{Price} , RAM :{RAM} ";
        }

    }
}
