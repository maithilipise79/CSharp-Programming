using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public class Book
    {
       
        public string Title {  get; set; }
        public string Author { get; set; }
        public double Price {  get; set; }

        public Book()
        {

        }
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public override string ToString()
        {
            return $" Title : {Title} ,Author : {Author} ,Price :{Price}";
        }

    }
}
