using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.WatchHelper
{
    public class WatchIdWiseSort : IComparer<Watch>
    {
        public int Compare(Watch? x, Watch? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
