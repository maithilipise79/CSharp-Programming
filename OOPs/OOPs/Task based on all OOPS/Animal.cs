using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }

    public class Dog:Animal
    { 
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }

}
