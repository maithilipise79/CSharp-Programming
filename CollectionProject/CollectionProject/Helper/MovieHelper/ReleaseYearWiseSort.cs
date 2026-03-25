using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.MovieHelper
{
    public class ReleaseYearWiseSort : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.ReleaseYear.CompareTo(y.ReleaseYear);
        }
    }
}
