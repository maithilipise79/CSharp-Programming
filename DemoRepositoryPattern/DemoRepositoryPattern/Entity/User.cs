using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepositoryPattern.Entity
{
    public class User  : BaseEntity
    {

        public string Name {  get; set; }
        public string Email { get; set; }
       
        //tostring 
        public override string ToString()
        {
            return $"User [Id :{base.Id} , Name :{this.Name} , Email :{this.Email} ,]";
        }
    }
}
