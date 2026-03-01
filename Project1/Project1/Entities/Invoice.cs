using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Invoice : BaseEntity
    {
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }


        public override string ToString()
        {
            return $"Invoice [ ID :{Id} , Total Amount :{TotalAmount}  ]";
        }
    }
}
