using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper
{
    public class NameWiseSort : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
