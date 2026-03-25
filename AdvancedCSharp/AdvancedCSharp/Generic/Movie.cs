using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic
{
    //public class Movie
    //{
    //    public int ID{ get; set; }
    //    public string Name { get; set; }
    //    public int ReleaseYear {  get; set; }

    //    public override string ToString()
    //    {
    //        return $"ID ;{ID} , Name :{Name} ,ReleaseYear : {ReleaseYear}";
    //    }
    //}

    //public interface IMovieRepository
    //{ 
    //    public void Add(Movie movie);
    //    public void GetMovieByID(int id);
    //    public void Delete(int id);
    //    public List<Movie> GetAllMovies();
    //}

    //public class MovieRepository: IMovieRepository
    //{
    //    public List<Movie> movies = new List<Movie>();

    //    public void Add(Movie movie)
    //    {
    //        if(movie == null)
    //        {
    //            Console.WriteLine("Movie is requires");
    //            return;
    //        }
    //        movies.Add(movie);

    //    }
    //    public void GetMovieByID(int id)
    //    {
    //        Console.WriteLine($"{movies.FirstOrDefault(x=>x.ID== id)}");
    //    }

    //    public void Delete(int id)
    //    {
    //        movies.RemoveAll(n => n.ID == id);
    //    }
        
    //    public List<Movie> GetAllMovies()
    //    {
    //        return movies;
    //    }

    //}



}
