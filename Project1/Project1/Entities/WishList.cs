using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.EntityClass
{
    public class WishList : BaseEntity
    {
        public int ItemCount { get; set; }

        public override string ToString()
        {
            return $"WishList [ID :{Id} , ItemCount : {ItemCount}] ";
        }

    }
}
