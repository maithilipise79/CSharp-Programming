using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Entity.Restaurant
{
    public class Feedback:BaseEntity
    {
        public string CustomerName {  get; set; }
        public string Comments {  get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return $"Rating [ID :{base.Id}, CustomerName :{CustomerName} ,Comments :{Comments} ,Rating :{Rating} ]";
        }
    }
}
