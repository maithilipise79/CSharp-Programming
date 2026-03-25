using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Car:IComparable<Car>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price {  get; set; }

        public Car() { }

        public Car(int id, string name, double price)
        {
            Id = id; Name = name; Price = price;
        }

        public override string ToString()
        {
            return $"Id :{Id} , Name :{Name} ,Price :{Price}";
        }

        public int CompareTo(Car? other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
