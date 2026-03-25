using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public class AdditionCalculator
    {
        public void Add(int a, int b)=>Console.WriteLine($"{a} + {b} => {a+b}");
        public void Add(double  a, double b)=>Console.WriteLine($"{a} + {b} => {a + b}");
        public void Add(int a,int b,int c)=>Console.WriteLine($"{a} + {b} + {c} => {a+b+c}");


    }
}
