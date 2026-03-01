using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Discount : BaseEntity
    {
        public int Code { get; set; }
        public int DiscountPercent { get; set; }


        public override string ToString()
        {
            return $"Discount [ Code : {Code} , Discount :{DiscountPercent} ]";
        }

    }
}
