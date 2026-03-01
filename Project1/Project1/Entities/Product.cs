using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public int StockQuantity { get; set; }

        public override string ToString()
        {
            return $"Product :[ID :{base.Id} , Name : {Name}, Price : {Price}, StockQuantity :{StockQuantity} ]";
        }
    }
}
