using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.MODELS
{
    public  class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public decimal Salary { get; set; }


        public Employee()
        {

        }

        public Employee( string name, int departmentID, decimal salary)
        {
      
            Name = name;
            DepartmentID = departmentID;
            Salary = salary;
        }
        public Employee( int id,string name, int departmentID, decimal salary)
        {
            ID=id;
            Name = name;
            DepartmentID = departmentID;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Emp [ID :{ID} , Name :{Name} ,Department ID :{DepartmentID} , Salary :{Salary}  ]";
        }
    }
}
