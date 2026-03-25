using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.LaptopHelper
{
    public class LaptopPriceWiseSort : IComparer<Laptop>
    {
        public int Compare(Laptop? x, Laptop? y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
