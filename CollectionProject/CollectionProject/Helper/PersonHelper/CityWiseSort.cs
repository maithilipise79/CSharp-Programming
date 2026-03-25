using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.PersonHelper
{
    public class CityWiseSort : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x.City.CompareTo(y.City);
        }
    }
}
