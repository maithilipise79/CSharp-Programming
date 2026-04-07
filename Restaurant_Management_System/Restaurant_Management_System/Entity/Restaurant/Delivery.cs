using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Entity.Restaurant
{
    public class Delivery:BaseEntity
    {
        public string DeliveryPersonName {  get; set; }
        public string Address {  get; set; }
        public string ContactNumber {  get; set; }
        public string Status {  get; set; }

        public override string ToString()
        {
            return $"Delivery [ID :{base.Id} ,DeliveryPersonName:{DeliveryPersonName} ,Address:{Address} ,ContactNumber:{ContactNumber} ,Status:{Status} ]";
        }
    }
}
