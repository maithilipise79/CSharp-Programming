using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper
{
    public class IdWiseSort : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Id.CompareTo(y.Id);
        }

    }
}
