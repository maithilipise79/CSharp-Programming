using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int NumberOfProduct { get; set; }

        public override string ToString()
        {
            return $"Category :[ Id :{base.Id} , Name :{Name} ,Number Of Product :{NumberOfProduct}";
        }

    }
}
