using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    internal class class1
    {
        public static void Sum<T>(T val,T val2)
        {
            dynamic num1 = val;
            dynamic num2 = val2;
            Console.WriteLine($"{val} + {val2} = {num1 + num2}");
            
        }

        public void Max<T>(T val1,T val2,out T MaxNo)
        {
            dynamic num1 = val1;
            dynamic num2 = val2;
            MaxNo = (num1 >= num2) ? val1 : val2;
        }
    }
}
