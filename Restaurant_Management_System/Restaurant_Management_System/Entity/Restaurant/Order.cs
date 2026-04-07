using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Entity.Restaurant
{
    public class Order :BaseEntity
    {
        public int Quantity {  get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount {  get; set; }

        public override string ToString()
        {
            return $"Order [ID :{base.Id} ,Quantity :{Quantity} ,Status :{Status} ,Price:{Price},Total Amount :{TotalAmount} ]";
        }
    }
}
