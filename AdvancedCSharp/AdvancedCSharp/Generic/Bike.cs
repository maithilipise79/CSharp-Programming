using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic
{
    //public class Bike
    //{
    //    public int Id {  get; set; }
    //    public string Company {  get; set; }
    //    public string ModelName { get; set; }

    //    public double Price { get; set; }

       

    //    public override string ToString()
    //    {
    //        return $"Company :{Company} ,Model :{ModelName} ,Price :{Price} ";
    //    }

    //}

    //public interface IBikeRepository
    //{
    //    public void AddBike(Bike bike);
    //    public void RemoveBike(int id);
        

    //    public List<Bike> GetAllBike();
    //    public List<Bike> SortBikeByPrice();
    //}

    //public class BikeRepository:IBikeRepository
    //{ 
    //    public List<Bike> Bikes=new List<Bike>();

    //    public void AddBike(Bike bike)
    //    {
    //        Bikes.Add(bike);
    //    }

    //    public void RemoveBike(int id)=>Bikes.RemoveAll(b => b.Id == id);
        
    //    public List<Bike> GetAllBike()
    //    {
    //        return Bikes;
    //    }
    //    public List<Bike> SortBikeByPrice()
    //    {
    //        return Bikes.OrderBy(b => b.Price).ToList();
    //    }
    //}

}
