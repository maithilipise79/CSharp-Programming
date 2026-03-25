using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.CountryHelper
{
    public class PopulationWiseSort : IComparer<Country>
    {
        public int Compare(Country? x, Country? y)
        {
            return x.Population.CompareTo(y.Population);
        }
    }
}
