using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Students
    {
        public string Name { get; set; }
        public int Age {  get; set; }

        public Students(string name, int age)
        {
            Name = name; Age = age;
        }
        public override string ToString()
        {
            return $"Name :{Name} ,Age {Age}";
        }
    }
}
