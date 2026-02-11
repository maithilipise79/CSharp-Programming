using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.IntermediateLevelProblem
{
    //8)Create overloaded methods where parameter order is different but types are same.

    public class DifferentOrder
    {
        public static void M1(int a,string name,double salary)
        {
            Console.WriteLine($"Id :{a} ,Name :{name} , Salary : {salary} ");
        }
        public static void M1(string name,int a,double salary)
        {
            Console.WriteLine($"Id :{a} ,Name :{name} , Salary : {salary} ");
        }
        public static void M1(string name,double salary,int a)
        {
            Console.WriteLine($"Id :{a} ,Name :{name} , Salary : {salary} ");
        }
        public static void M1(int a,double salary, string name)
        {
            Console.WriteLine($"Id :{a} ,Name :{name} , Salary : {salary} ");
        }
    }
}
