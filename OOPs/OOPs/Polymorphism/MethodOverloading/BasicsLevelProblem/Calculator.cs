using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.BesicLevelProblem
{
    public class Calculator1
    {
        //1. Create a class Calculator and overload a method Multiply(): (Two integers, Three integers)
        public static int Multiply(int a, int b) => a * b;
        public static int Multiply(int a,int b,int c) => a * b * c;
        public static int Multiply(int a, int b, int c, int d) => a * b * c * d;

    }
}
