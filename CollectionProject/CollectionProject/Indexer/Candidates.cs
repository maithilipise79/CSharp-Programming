using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Indexer
{
    public class Candidates
    {
        public int Id {  get; set; }
        public string Name { get; set; }    
        public string City {  get; set; }

        public Candidates() { }

        public Candidates(int id, string name, string city)
        {
            Id = id; Name = name; City = city;
        }

        public override string ToString()
        {
            return $"ID :{Id} , Name :{Name} , City :{City}";
        }
    }
}
