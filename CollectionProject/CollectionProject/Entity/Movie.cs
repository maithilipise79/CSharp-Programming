using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Collection {  get; set; }
        public int ReleaseYear {  get; set; }

        public Movie() { }

        public Movie(int id, string name, double collection, int releaseYear )
        {
            Id = id;
            Name = name;
            Collection = collection;
            ReleaseYear = releaseYear;
        }

        public override string ToString()
        {
            return $" Id :{Id} , Name :{Name} , Collection :{Collection} , Release Year :{ReleaseYear}";
        }
    }
}
