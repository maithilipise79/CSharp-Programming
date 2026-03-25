using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Interface
{
    internal class Class1
    {
    }

    interface IShapeInfo
    {
        double Area();
        double Perimeter();
        void Display();

    }
    public class Circles : IShapeInfo
    { 
        public double Redius {  get; set; }
        
        public  double Area()
        {
            return Math.PI * Redius*Redius;
        }
        public double Perimeter()
        {
            return 2*(Math.PI * Redius);
        }
        public void Display()
        {
            Console.WriteLine(" ");
        }
    }




}
