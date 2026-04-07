using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Entity.Restaurant
{
    public class MenuItem:BaseEntity
    {
        public string Name { get; set; }
        public string Category {  get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"MenuItem [ ID :{base.Id} ,Name :{Name} ,Category :{Category} ,Price :{Price} ]";
        }
    }
}
