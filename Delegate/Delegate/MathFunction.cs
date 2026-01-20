using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class MathFunction
    {
        
        //static method
        public static int FindMax(int n1, int n2)
        {
            int result=(n1 >= n2) ? n1 : n2; //lambda function
            return result;
        }

        //non-static method
        public int FindMin(int n1, int n2) => (n1 <= n2) ? n1 : n2;


        //create methods for multicast delegate
        public static void  CheckEven(int n)
        {
            string result = (n % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine($"{n} is {result}");
        }
        public static void  CheckPositive(int n)
        {
            string result =(n > 0) ? "Positive Number" : (n < 0) ? "Negative Number" : "Number is Zero";
            Console.WriteLine($"{n} is {result}");

        }
        public static void  CheckDivByFive(int n)
        {
            string result =(n % 5 == 0) ? "Divisible by five" : "Does not dividible by five";
            Console.WriteLine($"{n} is {result}");

        }

       
        public void ChekeUpperCase(char c)
        {
            if(c>='a'&&c<='z')
            {
                Console.WriteLine("Lower case");
            }
            else
            {
               Console.WriteLine("Upper case");
            }
        }

    }
}
