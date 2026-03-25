using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.PersonHelper
{
    public class PersonIdWiseSort : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
