using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPs.Models
{
    
    public class Class1
    {

        

    }
    //05/02/2026
    //Inheritance 
    //practice  questions 



    //Question 1
    //Create a base class Person with properties Name and Age.
    //Create a derived class Student that adds a property RollNumber.
    //- Write a program to create a Student object and display all details.
    public class Person1
    {
        public string Name1 { get; set; } = "Maithili";
        public int Age1 { get; set; } = 23; 

    }
    public class Student6 :Person1
    {
        public int RollNo1 { get; set; } = 101;

    }




    //Question 2
    //Define a base class Vehicle with a method Drive().
    //Create a derived class Car that adds a method Honk().
    //- Write a program to create a Car object and call both methods.
    public class Vehical
    {
        public void Drive()
        {
            Console.WriteLine("This is parent class");
        }
    }
    public class Car1:Vehical
    {
        public void Horn()
        {
            Console.WriteLine("This is child class");
        }
    }

    //Question 3
    //Create a base class Employee with a method Work().
    //Create a derived class Manager that adds a method ManageTeam().
    //- Demonstrate how a Manager object can access both methods.
    public class Employee1
    { 
        public static void Work()
        {
            Console.WriteLine("Empolyee class");
        }
    }
    public class Manager: Employee1
    {
        public static void ManageTeam()
        {
            Console.WriteLine("Manges class");
        }
    }




    //Question 4
    //Write a base class Shape with a method Area().
    //Create a derived class Rectangle that overrides Area() to calculate area using length and width.
    //- Show how polymorphism works when you reference a Rectangle object using a Shape type.
    //public class Shape
    //{
    //    public double Area( double length,double breadth)
    //    {
    //        Console.WriteLine("Shape Class ");
    //        return length * breadth;
    //    }
    //}
    //public class Rectangle :Shape
    //{
    //    public double Area(double length, double breadth)
    //    {
    //        Console.WriteLine("Rectangle Class ");
    //        return length * breadth;
    //    }
    //}

    //override methos 
    //In C#, for a method to be overridden, the base method must be marked as virtual (or abstract), and the derived method must use the override keyword.

    public class Shape
    {
        public virtual double Area( double length,double breadth)
        {
            Console.WriteLine("Shape Class ");
            return length * breadth;
        }
    }
    public class Rectangle :Shape
    {
        public override double Area(double length, double breadth)
        {
            Console.WriteLine("Rectangle Class ");
            return length * breadth;
        }
    }



    //Question 5
    //Create a base class Animal with a method Sound().
    //Create two derived classes Dog and Cat that override Sound().
    //- Write a program to demonstrate how different objects produce different outputs when calling Sound().
    //
    class Animal
    {
        public virtual void Sound() => Console.WriteLine("Animal sound");
    }
    class Dog:Animal
    {
        public override void Sound() => Console.WriteLine("Bark");    
    }
    class Cat:Animal
    {
        public override void Sound() => Console.WriteLine("meow meow");
    }



    //=============================================================================================================================
    //06/02/2026
    ////Inheritance
    //Class Work

    // Is a relationship
    // An object Extend or inherited property to another class 



    //1)---------------------
    //public class P
    //{
    //    public void M1()
    //    {
    //        Console.WriteLine("P");
    //    }
    //}
    //public class C:P
    //{
    //    //C class automatically inherited P class M1() Method
    //}


    //2)-----------------------
    //public class P
    //{
    //    public void M1()
    //    {
    //        Console.WriteLine("P");
    //    }
    //}
    //public class C : P
    //{
    //    public void M1()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}



    //3)-----------------------
    //public class P
    //{ 
    //    public virtual void M1()
    //    {
    //        Console.WriteLine("P");
    //    }
    //}
    //public class C:P
    //{
    //    public override void M1()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}


    ////4)----------------------
    //public class P
    //{ 

    //}
    //public class C:P
    //{
    //    public  void M1()
    //    {
    //        Console.WriteLine("C");
    //    }
    //}


    //5)------------------------
    //public class P
    //{
    //    public void M1()
    //    {
    //        Console.WriteLine("P --> M1");
    //    }
    //}
    //public class C:P
    //{
    //    public void M2()
    //    {
    //        Console.WriteLine("C --> M2");
    //    }
    //}



    //======================================================================================================================
    //Constructor Chaining In Inheritance


    ////here we are going to see the constructor chaining in inheritance
    //constructor chaining is the process of calling one constructor from another constructor in the same class or in the base class.
    //It is used to avoid code duplication and to initialize the object in a consistent way.

    //eg-
    //here we have create SparrowChild Object and we are calling the constructor of Sparrow class andthen the constructor of Bird class.
    //This is called constructor chaining in inheritance.


    //public class Bird
    //{
    //    public Bird()
    //    {
    //        Console.WriteLine("Bird");
    //    }
    //}
    //public class Sparrow:Bird
    //{
    //    public Sparrow()
    //    {
    //        Console.WriteLine("Sparrow");
    //    }

    //}
    //public class SparrowChild:Sparrow
    //{ 
    //    public SparrowChild()
    //    {
    //        Console.WriteLine("SaprrowChild");
    //    }
    //}


    //---------------------------------------------


    public class Bird
    { 
        public Bird()
        {
            Console.WriteLine("Bird");
        }
    }
    public class Sparrow : Bird 
    { 
        //public Sparrow(int a) ----//if write like this  then get CT error because SparroChild class compiler doesnt pass nay parameter
       //but when sparrowchild class constructor pass the parameter that time eorror is not occurs 
        public Sparrow(int num)  //Sparrowchild constructor pass the parameters
        {
            Console.WriteLine("Sparrow = "+num);
        }

    }
    public class SparrowChild : Sparrow
    {
        public SparrowChild():base(5)
        {
            Console.WriteLine("SparrowChild");
        }
    }





    //===================================================================================================================
    //07/02/2026
    //Homework

    //1)
    public class Circle
    { 
        public double Redius {  get; set; }
        public string Color { get; set;  }

        public Circle()
        {
            Redius = 3;
            Color = "Black";
        }
        public Circle(double redius)
        {
            Redius= redius;
            Color = "Black";
            
        }
        public Circle(double redius ,string color)
        {
            Redius = redius;
            Color = color;
        }

        public double GetArea() => 3.14 * Redius * Redius;
        
        public override string ToString()
        {
            return $" Redius of Circle = {Redius}\n Color of Circle = {Color}";
        }
    }
    public class Cylinder : Circle
    {
        public double Height { get; set; }
        
        public Cylinder()
        {
            Height = 4;
        }
        public Cylinder(double redius )
        {
            Height = 4;
        }
        public Cylinder(double redius ,double height):base(redius)
        {
            Height = height;
        }
        public Cylinder(double redius, double height,string color):base(redius,color)
        {
            Height = height;
        }

        public double GetVolume()=> 3.14 * Redius * Redius * Height;

    }


    //2)-------------------------------------------------------------------------

    public class Person
    {
        public string Name { get; set; }
        public string Address {  get; set; }

        public Person(string name,string address)
        {
            Name = name;
            Address= address;
        }

        public override string ToString()
        {
            return $"Person [ Name :{Name} ,Address :{ Address} ]";
        }
    }

    public class Student1 : Person 
    { 
        public string Program {  get; set; }
        public int Year {  get; set; }
        public double Fee {  get; set; }

        public Student1(string name,string address,string program,int year,double fee) : base(name,address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public override string ToString()
        {
            return $"Student [Person [Name :{base.Name} ,Address : {base.Address} ] Program :{Program} , Year :{Year} ,Fees :{Fee} ]";
        }
        
    }

    public class Staff : Person
    { 
        public  string School { get; set; }
        public double Pay { get; set; }
        public Staff(string name,string address,string School,double pay): base(name,address)
        {
            this.School = School;
            Pay = pay;
        }

        public override string ToString()
        {
            return $"Staff [Person [name :{Name} ,Address :{Address} ] School :{School} , Pay :{Pay}";
        }


    }



    //3)--------------------------------------------------------------------------------

    public class Point2D
    {
        public float X {  get; set; }
        public float Y { get; set; }

        public Point2D()
        {
            X = 2;
            Y = 2;
        }
        public Point2D(float x,float y)
        {
            X = x;
            Y = y;
        }

        public void XY(float x,float y)
        {
            X = x; Y = y;
        }

        
        //public float[] GetXY()
        //{
        //    return new float[] {X,Y};
        //}
        

        public override string ToString()
        {
            return $"X :{X} ,Y :{Y}";
        }
    }
    public class Point3D :Point2D
    {
        public float Z { get; set; }

        public Point3D()
        {
            Z = 5;

        }
        public Point3D(float x,float y,float z): base(x,y)
        {
            Z = z;
        }

        public void XYZ(float x,float y,float z)
        {
            base.X = x;
            base.Y = y;
            Z = z;
        }

        //public float[] getXYZ()
        //{
        //    return new float[] {X,Y,Z};
        //}
        public override string ToString()
        {
            return $" X:{base.X} ,Y :{base.Y} ,Z :{Z}";
        }

    }





}
