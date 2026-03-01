using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Review : BaseEntity
    {
        public string ProductName { get; set; }

        public string CustomerName { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return $"Review [ ID :{base.Id} , Product Name: {ProductName}, Customer Name : {CustomerName} , Rating : {Rating} ]";
        }


    }
}
