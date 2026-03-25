using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw a Shape");
        }
    }
    public class Circle: Shape
    { 
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle Shape");
        }
    }

    public class Rectangle : Shape
    { 
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle Shape");
        }
    }


}
