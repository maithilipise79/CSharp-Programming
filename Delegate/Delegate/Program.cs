using System;
namespace Delegate;

class Program
{
    //static method 
    public static string Prime(int n)
    {
        if (n <=1)
        {
            return "not prime";
        }
        for(int i=2;i<=n/2;i++)
        {
            if(n%i==0)
            {
                return "not prime";
            }
        }
        return "prime number";
    }
    //create delegate
    public delegate string CheckPrime(int n);

    //non-static method
    public int Factorial(int n)
    {
        int fact = 1 ;
        for(int i=1;i<=n;i++)
        {
            fact = fact * i;
        }
        return fact;
    }
    public int SumUptoNum(int n)
    {
        int sum = 0;
        for(int i=1;i<=n;i++)
        {
            sum += i;
        }
        return sum;
    }
    //create delegate
    public delegate int MyDelegate(int n); //we use multiple time for same signature method

    //create delegate for 2 parameters 
    public delegate int Math(int n1, int n2);


    public static void Triangle(int row)
    {
        for(int i=1;i<=row;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public  void HTriangle(int row)
    {
        for (int i = 1; i <= row; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if(i==1||i==row||i==j)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }

    //craete delegate for multicast example
    public delegate void Multicast(int n);

    public static bool CheckUpperCase(char c) => (c >= 'A' && c <= 'Z');

    public  bool CheckLowerCase(char c) => (c >= 'a' && c <= 'z');


    public static void Main(String[] args)
    {
        //delegate

        //1.simple delegate 

        //when function is static and in same class
        //CheckPrime p = Prime;       //point function
        //Console.WriteLine(p(7));


        //when function is non static but in same class
        //Program obj = new Program();
        //MyDelegate r1 = obj.Factorial;   
        //Console.WriteLine(r1(4));
        //MyDelegate r2 = obj.SumUptoNum;
        //Console.WriteLine(r2(7));


        //when function is static and in another class
        //Math max = MathFunction.FindMax;
        //Console.WriteLine("Maximum no :" + max(64, 74));


        //when function is non static but in another class 
        //MathFunction Math = new MathFunction();
        //max = Math.FindMin;
        //Console.WriteLine("Min no =" + max(44, 75));



        //======================================================================================================================


        //Multicast Delegate

        //Multicast m = MathFunction.CheckEven;
        //m += MathFunction.CheckPositive;
        //m += MathFunction.CheckDivByFive;
        //m(6);
        //m(10);
        //m -= MathFunction.CheckDivByFive;
        //m(4);



        //========================================================================================================================


        //Generic delegate                        (we dont need to create delegate)

        //Func Delegate

        //when function is static and in same class
        //Func<int, string> IsPrime = Prime;
        //Console.WriteLine(IsPrime(7));
        //Console.WriteLine(IsPrime(10));

        //when function is static but in another class
        //Func<int, int, int> MaxNo = MathFunction.FindMax;
        //Console.WriteLine("Max no is :"+MaxNo(54, 86));

        //when Function is non-static and in another class
        //MathFunction obj = new MathFunction();
        //Func<int, int, int> MinNo = obj.FindMin;
        //Console.WriteLine("Min no is :" + MinNo(53, 75));

        //lambda with Func
        //Func<int, int> Square = (num) => num * num;
        //Console.WriteLine(Square(16));
        //Func<int, string> CheckEven = (num) => (num % 2 == 0) ? "Even" : "odd";
        //Console.WriteLine(CheckEven(1));






        //Action(for void function)

        //when function in same class and its static 
        //Action<int> Demo = Triangle;
        //Demo(5);

        //when method in another class and its static
        //Demo += MathFunction.CheckPositive;
        //Demo(-48);

        //when function in the same class but its nonstatic 
        //Program p = new Program();
        //p.HTriangle(5);

        //when method is in another class and its non static
        //MathFunction m = new MathFunction();
        //Action<char> CheckCase = m.ChekeUpperCase;
        //CheckCase('A');


        //by sing lamda
        //Action<int>val=(num) =>Console.WriteLine("Number is "+num);
        //val(56);
        //Action<int> Square = (num) => Console.WriteLine($"Square of {num} :" + num * num);
        //Square(14);



        //Predicate 

        //by using lamda
        //Predicate<int> CheckPositive = (num) => num >= 0;
        //Console.WriteLine(CheckPositive(5));

        //static and in same class
        //Console.WriteLine(CheckUpperCase('v'));

        //when method is non static and in same class
        //Program obj = new Program();
        //Predicate<char> CheckLowwerCase = obj.CheckLowerCase;
        //Console.WriteLine(CheckLowwerCase('c'));
    }

}
