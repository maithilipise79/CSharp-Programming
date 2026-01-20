using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    internal class GenericClass<T>
    {
        public static void DisplayMassage( T msg)
        {
            Console.WriteLine(msg);
        }

        public void Swapping(ref T val1 ,ref T val2)
        {
            T val3 = val1;
            val1 = val2;
            val2 = val3;

        }

        public  void Add(T val1,T val2,T val3,out T sum)
        {
            dynamic n1 = val1;
            dynamic n2 = val2;
            dynamic n3 = val3;
            sum = n1 + n2 + n3;

        }
    }
}
