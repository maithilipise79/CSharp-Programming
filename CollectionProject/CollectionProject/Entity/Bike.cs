using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Bike() { }
        public Bike(int bikeId, string name, double price)
        {
            BikeId = bikeId;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Bike Id :{BikeId} , Name : {Name} , Price :{Price}";
        }
    }
}
