using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.IntermediateLevelProblem
{
    public class Addition
    {
        public static double Add(int a, double b, decimal c) => a + b + (double)c;
        public static double Add(int a, decimal c, double b) => a + b + (double)c;
        public static double Add( double b, int a, decimal c) => a + b + (double)c;
        public static double Add(decimal c, int a,  double b) => a + b + (double)c;
        public static double Add( double b, decimal c, int a) => a + b + (double)c;
    }
}
