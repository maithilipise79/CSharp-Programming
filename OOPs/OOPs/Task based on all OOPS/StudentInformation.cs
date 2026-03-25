using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public  class StudentInformation
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Marks {  get; set; }

        public StudentInformation()
        {

        }
        public StudentInformation(int rollNo, string name, int marks)
        {
            RollNo = rollNo;
            Name = name;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"RollNo :{RollNo} \nName : {Name} \nMarks :{Marks}");
        }
    }
}
