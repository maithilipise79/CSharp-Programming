using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionProject.Entity;

namespace CollectionProject.Helper.BikeHelper
{
    public class BikeIdWiseSort : IComparer<Bike>
    {
        public int Compare(Bike? x, Bike? y)
        {
            return x.BikeId.CompareTo(y.BikeId);
        }
    }
}
