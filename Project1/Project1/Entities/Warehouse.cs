using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    
    public class Warehouse : BaseEntity
    {
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string ManagerName { get; set; }

        public override string ToString()
        {
            return $"Warehouse [ ID : {base.Id} , Location :{Location} , Capacity : {Capacity} , Manager Name : {ManagerName} ";
        }
    }
}
