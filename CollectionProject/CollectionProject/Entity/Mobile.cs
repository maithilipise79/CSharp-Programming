using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Mobile
    {
        public int Id {  get; set; }
        public string Model {  get; set; }
        public double Price {  get; set; }

        public Mobile() { }

        public Mobile(int id, string model, double price )
        {
            Id = id;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID :{Id} , Model Name : {Model} ,Price : {Price} ";
        }
    }
}
