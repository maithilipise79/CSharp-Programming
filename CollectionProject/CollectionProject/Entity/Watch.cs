using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Watch
    {
        public int Id {  get; set; }
        public string Type { get; set; }
        public string Company { get; set; }

        public double Price {  get; set; }

        public Watch(int id,string type, string company,double price)
        {
            this.Id = id;
            Type=type;
            Company=company;
            Price=price;
        }

        public Watch() { }

        public override string ToString()
        {
            return $"ID :{Id} ,Comapny :{Company} , Type :{Type} , Price :{Price}";
        }
    }
}
