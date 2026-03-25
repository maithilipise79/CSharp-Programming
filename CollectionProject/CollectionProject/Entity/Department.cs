using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NoOfTeachers {  get; set; }

        public Department() { }

        public Department(int id, string name, int noOfTeachers)
        {
            Id = id;
            Name = name;
            NoOfTeachers = noOfTeachers;
        }

        public override string ToString()
        {
            return $" ID :{Id} , Name :{Name} , Number Of Teachers :{NoOfTeachers}";
        }
    }

}
