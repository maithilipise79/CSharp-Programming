using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverriding
{
    public abstract class Shapes
    {
        public static string Color { get; set; }
        public static bool Filled { get; set; }

        public Shapes()
        {
            Color = "red";
            Filled = true;

        }
        public Shapes(string color ,bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public abstract double  GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"Shape [color :{Color} ,filled :{Filled} ]";
        }

    }

    public class Circle1 :Shapes
    {
        public double Redius { get; set; } 

        public Circle1()
        {
            Redius = 1.0;
        }
        public Circle1(double redius )
        {
            Redius = redius;
        }

        public Circle1(double redius,string color,bool filled):base(color,filled)
        {
            Redius = redius;
        }
        public override double GetArea()
        {
            return Math.PI* Redius *Redius;
        }
        public override double GetPerimeter()
        {
            return 2*Math.PI*Redius;
        }
        
        public override string ToString()
        {
            return $"Circle : [Shape [Color :{Shapes.Color}  ,redius :{Redius}";
        }

    }
    public class Rectangle1:Shapes
    {
        public static double Width { get; set; }
        public static double Length { get; set; }

        public Rectangle1()
        {
            Width = 1.0;
            Length = 1.0;
        }

        public Rectangle1(double width, double length)
        {
           Width=width;
           Length=length;

        }
        public Rectangle1(double width, double length, string Color,bool Filled):base(Color,Filled)
        {
           Width=width;
           Length=length;
        }

        //public Rectangle(string color, bool filled) : base(color, filled)
        //{
        //}

        public override double GetArea()
        {
            return Width*Length;
        }
        public override double GetPerimeter()
        {
            return 2*(Width+ Length);
        }
        public override string ToString()
        { 
            return $"Rectangle [Shape [color: {Shapes.Color} , Filled: {Shapes.Filled} ],width ;{Width} Length: {Length}] ";
        }
    }

    public class Square:Rectangle1
    {
        public double Side { get; set; }

        public Square(double side )
        {
            Side = side;

        }
        public Square(double side, string color, bool filled):base(side,side,color,filled)
        {
            Side = side;
        }
        public override string ToString()
        {
            return $"Square [Rectangle [Shapes [Color :{Shapes.Color} , filled :{Shapes.Filled} ] ,width :{Rectangle1.Width} , Length : {Rectangle1.Length} ]]";
        }


    }


}
