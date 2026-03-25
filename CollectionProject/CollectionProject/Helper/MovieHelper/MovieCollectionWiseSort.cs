using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.MovieHelper
{
    public class MovieCollectionWiseSort : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.Collection.CompareTo(y.Collection);
        }
    }
}
