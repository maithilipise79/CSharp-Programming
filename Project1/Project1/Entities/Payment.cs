using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Payment : BaseEntity
    {
        public double Amount { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentMethod { get; set; }

        public override string ToString()
        {
            return $"Payment [ ID :{base.Id} , Amount : {Amount} , Payment Method : {PaymentMode} ,Payment Method : {PaymentMethod} ]";
        }
    }
}
