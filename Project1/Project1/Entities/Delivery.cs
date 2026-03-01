using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Delivery : BaseEntity
    {
        public string DeliveryAddress { get; set; }
        public string DeliveryCity { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"Delivery [ id : {base.Id} , Delivery Address :{DeliveryAddress} , Delivery City :{DeliveryCity} , Status : {Status} ]";
        }
    }
}
