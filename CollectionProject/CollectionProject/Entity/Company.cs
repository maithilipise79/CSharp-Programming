using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeCount { get; set; }

        public long TurnOver {  get; set; }

        public Company() { }
        public Company(int id, string name, int employeeCount, long turnOver )
        {
            Id = id;
            Name = name;
            EmployeeCount = employeeCount;
            TurnOver = turnOver;
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name :{Name} , Employee Count :{EmployeeCount} , TurnOver :{TurnOver} ";
        }
    }
}
