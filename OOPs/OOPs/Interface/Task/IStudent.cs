using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Interface.Task
{
    internal interface IStudent<T>
    {

        int CountOfPassStudent();
        int CountOfFailStudent();
         T Toper();

    }

    //public class StudentInfo
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Percentage {  get; set; }

    //    public StudentInfo(int id, string name, int percentage)
    //    {
    //        Id = id;
    //        Name = name;
    //        Percentage= percentage;
    //    }
    //}
    //public class StudentServices:IStudent
    //{
    //    public List<StudentInfo> Student {  get; set; }=new List<StudentInfo>();
        


    //    public int CountOfPassStudent()
    //    {
    //        return Student.Where(Student.Percentage >= 35).Count();
    //    }
    //    public int CountOfFailStudent()
    //    {
    //        return Student.Where(Student.Percentage < 35).Count();
    //    }
    //    public void  Toper()
    //    {
    //        var result = Student.Where(Student.Percentage >= 35).OrderByAsending().LastOrDeafult;

    //        Console.WriteLine 
    //    }
    
    //}

}
