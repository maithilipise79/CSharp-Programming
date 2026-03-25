using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public abstract class Vehicle
    {
        public abstract void Start();
        public  abstract void Stop();

    }

    public class Bike:Vehicle
    { 
        public override void Start()
        {
            Console.WriteLine("Bike is started");
        }
        public override void Stop()
        {
            Console.WriteLine("Bike is stop");
        }
       
    }

    public class Car : Vehicle
    { 
        public override void Start()
        {
            Console.WriteLine("Car is started");
        }
        public override void Stop()
        {
            Console.WriteLine("Car is stop");
        }
    }



}
