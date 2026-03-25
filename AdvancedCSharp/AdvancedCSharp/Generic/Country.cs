using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic
{
    //public class Country
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public string Capital {  get; set; }

    //    public string Language { get; set; }

    //    public override string ToString()
    //    {
    //        return $" ID :{Id} , Name :{Name} , Capital :{Capital}";
    //    }
    //}

    //public interface ICountryRepository
    //{ 
    //    public void AddCountry(Country country);
    //    public void RemoveCountry(int id);
    //    public void GetCountry(int id);
    //    public List<Country> GetAll();
    //}

    //public class CountryRepository: ICountryRepository
    //{
    //    public List<Country> countries=new List<Country>();

    //    public void AddCountry(Country country)
    //    {
    //        if(country==null)
    //        {
    //            Console.WriteLine("Country id required");
    //        }
    //        countries.Add(country);
    //    }

    //    public void RemoveCountry(int id)  
    //    {
    //        countries.RemoveAll(n=>n.Id==id);
    //    }

    //    public void GetCountry(int id)
    //    {
    //        Console.WriteLine($"{countries.FirstOrDefault(n=>n.Id==id)}");
    //    }

    //    public  List<Country> GetAll()
    //    {
    //        return countries;
    //    }


    //}

}
