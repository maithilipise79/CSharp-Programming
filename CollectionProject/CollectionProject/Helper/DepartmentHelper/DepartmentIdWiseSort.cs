using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.DepartmentHelper
{
    public class DepartmentIdWiseSort : IComparer<Department>
    {
        public int Compare(Department? x, Department? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
