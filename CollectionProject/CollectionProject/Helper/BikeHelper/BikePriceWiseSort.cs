using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.BikeHelper
{
    public class BikePriceWiseSort : IComparer<Bike>
    {
        public int Compare(Bike? x, Bike? y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
