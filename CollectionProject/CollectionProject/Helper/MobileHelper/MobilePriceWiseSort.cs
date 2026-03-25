using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.MobileHelper
{
    public class MobilePriceWiseSort : IComparer<Mobile>
    {
        public int Compare(Mobile? x, Mobile? y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}
