using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    public class Employee : IComparable <Employee>
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int EmployeeID { get; set; }

        public Employee() { }
        public Employee(string name, string position, int empolyeeID)
        {
            Name = name;
            Position = position;
            EmployeeID = empolyeeID;
        }
        //public int CompareTo(Employee o)
        //{

        //}
        public int CompareTo(Employee? other)
        {
            return this.EmployeeID.CompareTo(other.EmployeeID);
        }
        public override string ToString()
        {
            return $"Name :{Name} ,ID: {EmployeeID} ,Position :{Position}";
        }

        
    }


}
