using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.MODELS
{
    public class Department
    {
      public int ID {  get; set; }
        public string DepartmentName { get; set; }

        public Department() { }
        public Department( string departmentName)
        {
          
            DepartmentName = departmentName;
        }
        public Department( int id,string departmentName)
        {
          ID = id;
          DepartmentName = departmentName;
        }

        public override string ToString()
        {
            return $"Department [ ID :{ID} , Name :{DepartmentName}  ]";
        }
    }
}
