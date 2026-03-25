using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public class Person
    {
        public string Name {  get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($" Name :{Name} , Age :{Age}");
        }
    }
    public class Student : Person
    { 
        public int RollNo { get; set; }
        public int Marks {  get; set; }

        public Student()
        {

        }
        public Student(int RollNo, int Marks)
        {
            this.RollNo = RollNo;
            this.Marks = Marks;
        }
        public Student(int RollNo,int Marks, string name,int age):base(name, age) 
        {
            this.RollNo = RollNo;
            this.Marks = Marks;
        }

        public void Display()
        {
            Console.WriteLine($"Name :{Name} ,RollNo :{RollNo} ,Age :{Age} ,Marks :{Marks}");
        }
    }



}
