using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.BesicLevelProblem
{
    public class Shapes
    {
        //3)Overload a method Area() to calculate: (Area of square, Area of rectangle)

        public static void Area(double side)
        {
            Console.WriteLine("Area of Square is : " + side * side);
        }

        public static void Area(double length, double width)
        {
            Console.WriteLine("Area of Rectangle is :" + length * width);
        }

    }
}
