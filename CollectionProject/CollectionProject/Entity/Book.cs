using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public Book() { }

        public Book(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID :{Id} ,Title :{Title} ,Price :{Price} ";
        }

    }
}
