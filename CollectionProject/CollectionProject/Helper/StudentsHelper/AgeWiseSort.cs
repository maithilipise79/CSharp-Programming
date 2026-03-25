using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.StudentsHelper
{
    public class AgeWiseSort : IComparer<Students>
    {
        public int Compare(Students? x, Students? y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
