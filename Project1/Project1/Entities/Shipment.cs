using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
  
    public class Shipment : BaseEntity
    {
        public string Carrier { get; set; }
        public int TrackingNumber { get; set; }

        public override string ToString()
        {
            return $"Shipment [ ID :{Id} , Carrier : {Carrier} , Tracking Number : {TrackingNumber}]";
        }

    }
}
