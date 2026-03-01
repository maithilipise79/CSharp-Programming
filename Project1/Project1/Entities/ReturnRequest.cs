using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class ReturnRequest : BaseEntity
    {
        public string Reason { get; set; }
        public string RequestDate { get; set; }

        public override string ToString()
        {
            return $"ReturnRequest [ID : {Id} , Reason : {Reason} ,RequestDate : {RequestDate}]";
        }
    }
}
