using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.BasicsLevelProblem
{
    public class CheckOverloading
    {


        //5)Is method overloading possible by changing only return type ? Explain with code.


        public static void Show(int quantity,string product)
        {
            Console.WriteLine($"Product Name :{product} ,Quantity : {quantity}");
        }
        //public static int Show(int quantity,string product)
        //{
        //    Console.WriteLine($"Product Name :{product} ,Quantity : {quantity}");
        //    return quantity;
        //}
        //public static string Show(int quantity,string product)
        //{
        //    Console.WriteLine($"Product Name :{product} ,Quantity : {quantity}");
        //    return product;
        //}




        //Ans. NO
        //because even return type of method id different but still signature of the method is same;
        //signature (name,parameters)does not include return type 
        //That why method overloading is not possible id signature is same even return type is different

    }
}
