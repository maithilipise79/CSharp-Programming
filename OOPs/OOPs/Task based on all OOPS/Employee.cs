using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public class Employee
    {
        private double salary = 0;

        public void SetSalary(double salaryVal)
        {
            if(salaryVal>0)
            {
                salary = salaryVal;
           
            }
            else
            {
                Console.WriteLine("Something went wrong...");
            }
        }
        public double GetSalary()
        {
            return salary;
        }
    }
}
