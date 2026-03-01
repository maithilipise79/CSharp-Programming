using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Order : BaseEntity
    {

        public int ItemCount { get; set; }
        public double TotalAmount { get; set; }


        public override string ToString()
        {
            return $"Order [ ID :{base.Id} , Item Count : {ItemCount} ,Total Amount : {TotalAmount} ]";
        }
    }
}
