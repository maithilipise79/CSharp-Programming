using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class City
    {
        public String Name {  get; set; }
        public int Population {  get; set; }
        public int Pincode { get; set; }

        public City() { }
        public City(string name, int population, int pincode)
        {
            Name = name;
            Population = population;
            Pincode = pincode;
        }

        public override string ToString()
        {
            return $"Name :{Name} ,PIN Code :{Pincode} ,Population :{Population}";
        }
    }

}
