using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Product() { }
        public Product(int id, string name, double price)
        {
            Id=id;
            Name=name;
            Price=price;
        }
        public Product( string name, double price)
        {
          
            Name=name;
            Price=price;
        }

        public override string ToString()
        {
            return $",Name :{Name} ,Price :{Price}";
        }
    }
}
