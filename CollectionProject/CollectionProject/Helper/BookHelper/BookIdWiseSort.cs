using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.BookHelper
{
    public class BookIdWiseSort : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
