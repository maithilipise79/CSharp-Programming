using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besic
{
    internal class GenericDemo<T>
    {
        public void Show(T obj)
        {
            Console.WriteLine(obj);
        }

        public static void Display(T n1, T n2)
        {
            Console.WriteLine($" parameter one :{n1} and second is :{n2}");
        }


        public void Swap<T>(ref T val1, ref T val2)
        {
            T temp = val1;
            val1 = val2;
            val2 = temp;

        }

        //public static void Addition(T a, T b ,out T result)
        //{
        //    dynamic n1 = a;
        //    dynamic n2 = b;
        //   dynamic result = n1+n2;
        //}
    }
}
