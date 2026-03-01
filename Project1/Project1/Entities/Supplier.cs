using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
   
    public class Supplier : BaseEntity
    {
        public string SupplierName { get; set; }
        public long ContactNo { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"BaseEntity [ID :{Id} ,ContactNo : {ContactNo} ,Address :{Address}]";
        }
    }
}
