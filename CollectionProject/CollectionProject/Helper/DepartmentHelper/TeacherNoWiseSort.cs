using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.DepartmentHelper
{
    public class TeacherNoWiseSort : IComparer<Department>
    {
        public int Compare(Department? x, Department? y)
        {
            return x.NoOfTeachers.CompareTo(y.NoOfTeachers);
        }
    }
}
