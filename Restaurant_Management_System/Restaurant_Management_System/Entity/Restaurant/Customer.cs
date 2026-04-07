using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Entity.Restaurant
{
    public class Customer :BaseEntity
    {
        public string Name {  get; set; }
        public string Address { get; set; }
        public string Phone{ get; set; }

        public override string ToString()
        {
            return $" Customer [ID :{base.Id} ,Name :{Name} ,Address :{Address} ,Phone :{Phone} ]";
        }
    }
}
