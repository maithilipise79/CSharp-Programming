using EmployeeManagement.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.Builder
{
    public class EntityBuilder
    {
        public static Employee EmployeeBuilder()
        {
            //Console.WriteLine("Enter Employee ID :");
            //int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name ");
            string name = Console.ReadLine();
            Console.WriteLine(" Enter Department ID :");
            int deptId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary :");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            return new Employee( name, deptId, salary);
        }
        

        public static Department DepartmentBuilder()
        {
            //Console.WriteLine("Enter id :");
            //int deptId= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department Name :");
            string name= Console.ReadLine();

            return new Department(name);
        }

    }
}
 