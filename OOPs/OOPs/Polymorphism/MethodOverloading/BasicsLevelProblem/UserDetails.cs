using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.BasicsLevelProblem
{
    public class UserDetails
    {
        //4)Create a method PrintDetails() that takes: (name, name and age)
        public static void PrintDetails(string name,string Sname,int age)
        {
            Console.WriteLine($"Name : {name} {Sname} ,Age : {age}");
        }
        public static void PrintDetails(string name, int age, string Sname)
        {
            Console.WriteLine($"Name : {name} {Sname} ,Age : {age}");
        }
        public static void PrintDetails( int age,string name,string Sname)
        {
            Console.WriteLine($"Name : {name} {Sname} ,Age : {age}");
        }
    }
}
