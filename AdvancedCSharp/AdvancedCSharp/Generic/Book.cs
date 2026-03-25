using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp.Generic
{
    //public class Book
    //{
    //    public string Name {  get; set; }
    //    public string Author {  get; set; }
    //    public double Price {  get; set; }

    //    public override string ToString()
    //    {
    //        return $"Name :{Name} ,Author : {Author} ,Price : {Price}";
    //    }
    //}

    //public interface IBookRepository
    //{
    //    public void AddBook(Book book);
    //    public void DeleteBook(string name);

    //    public Book GetBookByName(string name);

    //    public List<Book> GetAllBook();
    //}

    //public class BookRepository : IBookRepository
    //{ 
    //    public static List<Book> books = new List<Book>();
    //    public void AddBook(Book book)
    //    {
    //        if(book == null)
    //        {
    //            Console.WriteLine("Book is required ");
    //            return;
    //        }
    //        books.Add(book);
    //    }

    //    public void DeleteBook(string name)
    //    {
    //        books.RemoveAll(b=>b.Name==name);
    //    }

    //    public Book GetBookByName(string name)
    //    {
    //        Book? ob= books.FirstOrDefault(b=>b.Name==name);
    //        return ob;
    //    }

    //    public List<Book> GetAllBook()
    //    {
    //        return books;
    //    }
    //}

}
