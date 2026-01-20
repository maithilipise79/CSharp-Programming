using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besic
{
    public static class MathFunction
    {
        public static int GetMax(int a, int b, int c)
        {
            int result = (a > b && a > c) ? a : (b > a && b > c) ? b : c;
            return result;
        }

        public static int GetSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        public static bool Strong(int num)
        {
            int sum=0;
             for(int i=num;i>0;i/=10)
            {
                int digit = i % 10;
                int mult=1;
                for(int j=1;j<=digit;j++)
                {
                    mult = mult * j;
                }
                sum = sum + mult;
            }
            return (sum == num) ? true : false;
        }


        public static string EvenOdd(int num) => (num % 2 == 0) ? "Even number" : "Odd number";

        public static bool DivisibleBoth(int num) => (num % 5 == 0 && num % 11 == 0) ? true : false;

        public static string LeapYear(int year) => (year % 4 == 0 && year % 400==0) ? "Leap Year" : "Not Leap Year";

        public static string CheckAlphabet(char c) => ((c >= 'a' && c <= 'z')||(c >= 'A' && c <= 'Z'))? "Alphabate" : "Not Alphabate";

        public static string CheckVowel(char c) => (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') ? "Vowel" : "Consonant";

        public static string CheckCharacter(char c) => ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) ? "Alphabate" : (c >= 0 && c <= 9) ? "Digit" : "Special Character";

        public static string CheckUppercase(char c) => (c <= 'Z' && c >= 'A') ? "Upper case" : "Lower Case";

        public static string WeekDay(int n)
        {
            string result = n switch
            {
                1=>"Monday",2=>"Tuesday",3=>"Wednesday",4=>"Thursday",5=>"Friday",6=>"Saturday",7=>"Sunday",_=>"Invalid input"
             };
            return result;
        }


        public static int DaysInMonth(int n)
        {
            int result = n switch
            {
                1=>31,2=>28,3=>31,4=>30,5=>31,6=>30,7=>31,8=>31,9=>30,10=>31,11=>30,12=>31,_=>0
            };
            return result;
        }


        public static void CountNotes(int n)
        {
            
            if(n>=500)
            {
                Console.WriteLine($" No of 500 notes :{n/500}");
                n = n % 500;
            }
            if(n>=200)
            {
                Console.WriteLine($" No of 200 notes :{n / 200}");
                n = n % 200;
            }
            if (n >= 100)
            {
                Console.WriteLine($" No of 100 notes :{n / 100}");
                n = n % 100;
            }
            if (n >= 50)
            {
                Console.WriteLine($" No of 50 notes  :{n / 50}");
                n = n % 50;
            }
            if (n >= 20)
            {
                Console.WriteLine($" No of 20 notes  :{n / 20}");
                n = n % 20;
            }
            if (n >= 10)
            {
                Console.WriteLine($" No of 10 notes  :{n / 10}");
                n = n % 10;
            }
            if (n >= 5)
            {
                Console.WriteLine($" No of 5 coins   :{n / 5}");
                n = n % 5;
            }
            if (n >= 2)
            {
                Console.WriteLine($" No of 2 coins   :{n / 2}");
                n = n % 2;
            }
            if (n >= 1)
            {
                Console.WriteLine($" No of 1 coins   :{n / 1}");
                n = n % 1;
            }

        }

        public static string ValidTriangle(int ang1,int ang2,int ang3)
        => ((ang1 + ang2 + ang3) == 180) ? "Valid" : "Not valid";
            
        //public static string Prime(int a)
        //{
        //    int flag = 0;
        //    for(int i=2;i<=a/2;i++)
        //    {
        //        if(a%i==0)
        //        {
        //            flag = 0;
        //            break;
        //        }
        //        else
        //        {
        //            flag = 1;
        //        }
        //    }
        //    string res = (flag == 1) ? "Prime Number" : "Not Prime";
        //    return res;
        //}

        
    }
}
