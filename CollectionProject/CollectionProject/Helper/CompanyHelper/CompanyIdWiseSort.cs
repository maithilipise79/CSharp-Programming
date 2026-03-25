using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.CompanyHelper
{
    public class CompanyIdWiseSort : IComparer<Company>
    {
        public int Compare(Company? x, Company? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
