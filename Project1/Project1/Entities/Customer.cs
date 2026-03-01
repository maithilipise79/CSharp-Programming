using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public long MobileNo { get; set; }

        public override string ToString()
        {
            return $"Customer [ID :{base.Id} , Address : {Address} , Mobile No : {MobileNo} ]";
        }
    }
}
