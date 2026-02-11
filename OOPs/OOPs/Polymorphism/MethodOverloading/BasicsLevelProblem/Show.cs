using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.BesicLevelProblem
{
    public class Show
    {
        //2) Create a method Display() that accepts: (int, string)
        public static void Display(int num,string name)
        {
            Console.WriteLine($"There are {num} {name} in 173 Batch");
        }

        public static void Display()
        {
            Console.WriteLine("hey...!! \nWhat's up!");
        }
    }
}
