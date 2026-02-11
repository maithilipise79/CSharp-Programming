using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.IntermediateLevelProblem
{
    public class StudentInfo
    {
        //6) Create a class Student and overload a method GetResult() : (Accept total marks, Accept marks of 3 subjects separately)

        public static string GetResult(int Total)=> ((Total / 3) > 35) ? "Pass" : "Fail";

        public static string GetResult(int sub1, int sub2, int sub3) => (sub1 >= 35 && sub2 >= 35 && sub3 >= 35) ? "Pass" : "Fail";
       
    }
}
