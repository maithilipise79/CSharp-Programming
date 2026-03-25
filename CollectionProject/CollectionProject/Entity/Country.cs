using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Country
    {
        public string Name {  get; set; }
        public long Population {  get; set; }
        public int CountryCode { get; set; }

        public Country() { }

        public Country(string name, long population, int countryCode)
        {
            Name = name;
            Population = population;
            CountryCode = countryCode;
        }

        public override string ToString()
        {
            return $" Name :{Name} , Population :{Population} , Country Code : {CountryCode}";
        }
    }
}
