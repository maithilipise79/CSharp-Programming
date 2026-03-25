using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Interface.Task
{
    //Design a vehicle interface that allows starting and stopping different vehicle types.
    internal interface IVehical
    {
        
        void Start();
        void Stop();

    }
    //public class VehicalInfo
    //{
    //    public string Name { get; set; }
    //    public string Fuel { get; set; }
    //    public VehicalInfo()
    //    {
    //        Name = "Fortuner";
    //        Fuel = "Disel";

    //    }
    //    public VehicalInfo(string name,string fuel)
    //    {
    //        Name=name;
    //        Fuel = fuel;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Name :{Name} ,Fuel :{Fuel}";
    //    }
    //}

    //public class Car : VehicalInfo,IVehical
    //{
    //    private readonly VehicalInfo vehical;

    //    public Car(VehicalInfo vehical)
    //    {
    //        this.vehical = vehical;
    //    }

    //    public void Start()
    //    {
    //        Console.WriteLine($"{vehical.Name} car  is Started");
    //    }
    //    public void Stop()
    //    {
    //        Console.WriteLine($"{vehical.Name} car is Stop");
    //    }

    //    public override string ToString()
    //    {
    //        return $" [Type :Car ,Car details :{vehical} ]";
    //    }
    //}
    //public class Bike: VehicalInfo,IVehical
    //{
    //    private readonly VehicalInfo vehical;

       
    //    public Bike(VehicalInfo vehical)
    //    {
    //        this.vehical = vehical;
    //    }

    //    public void Start()
    //    {
    //        Console.WriteLine($"{vehical.Name} bike is Started");
    //    }
    //    public void Stop()
    //    {
    //        Console.WriteLine($"{vehical.Name} bike is Stop");
    //    }
    //    public override string ToString()
    //    {
    //        return $" [Type :Bike ,Bike details :{vehical} ]";
    //    }
    //}


}
