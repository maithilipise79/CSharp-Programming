using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Entity.Restaurant
{
    public class Staff:BaseEntity
    {
        public string Name { get; set; }
        public string Role {  get; set; }
        public decimal Salary {  get; set; }
        public string Phone {  get; set; }

        public override string ToString()
        {
            return $"ID: {base.Id} ,Name :{Name} ,Role :{Role}, Salary :{Salary} ,Phone: {Phone} ]";
        }
    }
}
