using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.MobileHelper
{
    public class MobileIdWiseSort : IComparer<Mobile>
    {
        public int Compare(Mobile? x, Mobile? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
