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
            return $"Student " +
                $"{base.ToString()} Program :{Program} , Year :{Year} ,Fees :{Fee} ]";
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
            return $"Staff  {base.ToString()} School :{School} , Pay :{Pay}";
        }


    }



    //3)--------------------------------------------------------------------------------

    public class Point2D
    {
        public float X { get; set; } 
        public float Y { get; set; }

        public Point2D()
        {
            X = 2;
            Y = 2;
        }
        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void XY(float x, float y)
        {
            X = x; Y = y;
        }
        public float[] GetXY()
        {
            return new float[] { X, Y };
        }

        public override string ToString()
        {
            return $"X :{X} ,Y :{Y}";
        }
    }


    public class Point3D : Point2D
    {
        public float Z { get; set; }

        public Point3D()
        {
            Z = 2;

        }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            Z = z;
        }

        //public void XYZ(float x, float y, float z)
        //{
        //    base.X = x;
        //    base.Y = y;
        //    Z = z;
        //}

        //public float[] getXYZ()
        //{
        //    return new float[] { X, Y, Z };
        //}

        private float[] xyz=new float[3];
        public float[] XYZ 
        { 
            get{ return xyz; }
            set{ xyz = value; }
        }
         
        public override string ToString()
        {
            return $" X:{base.X} ,Y :{base.Y} ,Z :{Z}";
        }

    }




    //=====================================================================================================================================================
    //09/02/2026
    //Classwork







    //=====================================================================================================================================================
    //09/02/2026
    //Homework

    //1)
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public char Gender { get; set; }

        public Author(string name,string email,char gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Name} ({Gender}) at {Email}";
        }

    }

    public class Book
    {
        public string Name { get; set; }
        public Author Author1 { get; set; }
        public double Price{ get; set; }
        public int Quantity {  get; set; }

        public Book(string name,Author author, double price,int quantity)
        {
            Name = name;
            Author1 = author;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $" '{Name}' by {Author1}";
        }
    }



    //2)------------------------------------------------------------------------

    public class Customer
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }

        public Customer(int iD, string name, char gender )
        {
            ID = iD;
            Name = name;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Name} ({ID})";
        }
    }

    public class Account
    {
        public int ID { get; set; }
        public Customer Customer1 { get; set; }
        public double Balance {  get; set; }

        public Account(int iD, Customer customer1, double balance )
        {
            ID = iD;
            Customer1 = customer1;
            Balance = balance;
        }

        public Account(int id,Customer customer1)
        {
            ID = id;
            Customer1 = customer1;
        }

        public override string ToString()
        {
            return $"{Customer1.Name} ({ID})  balance = {Balance}";
        }

        public double Deposite(double amount)
        {
            Balance = amount + Balance;
            return Balance;
        }

        public double Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                Balance= Balance - amount;
                return Balance;
            }
            else
            {
                Console.WriteLine("amount withdraw exceeds the current balance");
                return Balance;
            }
        }
    }



    //3)--------------------------------------------------------------------------------

    public class Customer1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }   

        public Customer1(int iD, string name, int discount )
        {
            ID = iD;
            Name = name;
            Discount = discount;
        }

        public override string ToString()
        {
            return $" {Name} ({ID}) with discount {Discount} %";
        }

    }

    public class Invoice
    { 
        public int ID { get; set; }
        public Customer1 Customer1 { get; set; }
        public double Amount {  get; set; }

        public Invoice(int iD, Customer1 customer1, double amount)
        {
            ID = iD;
            Customer1 = customer1;
            Amount = amount;
        }

        public double AmountAfterDiscount()
        {
            Amount = Amount - (Amount * (Customer1.Discount/100));
            return Amount;
        }
    }

    //=============================================================================================================
    //HAS-A Relationship Layered Architecture Example

    public class TransactionRepository
    {
        private int[] _tranjaction = { 500, 700, -400, 600, 1000, -400, 100, -300, 900 };
        public int[] GetAllTransaction()
        {
            return _tranjaction;
        }
    }

    public class TransactionService
    {
        private readonly TransactionRepository repository;

        public TransactionService(TransactionRepository repository)
        {
            this.repository = repository;
        }

        public void AnalyzeTransactions()
        {
            var transaction= repository.GetAllTransaction();
            int balance = 0;
            foreach(var n in transaction)
            {
                balance += n;
                Console.WriteLine("Balance : "+balance);
            }
        }
    }

    public class TransactionController
    {
        private readonly TransactionService service;

        public TransactionController(TransactionService service)
        {
            this.service = service;
        }

        public void Run()
        {
            service.AnalyzeTransactions();
        }
    }


    //--------------------------------------------------------------------------------
    //Assignment 1: Library Book System

    public class LibraryRepository
    {
        private int[] bookPages = { 120, 450, 300, 700, 150, 90, 500 };
        public int[] GetBookPages()
        {
            return bookPages;
        }
    }

    public class LibraryServices
    {
        //Di
        private readonly LibraryRepository repository; 

        public LibraryServices(LibraryRepository repository1)
        {
            this.repository = repository1;
        }

        public int TotalBooks()
        {
            var count = repository.GetBookPages().Count();
            return count;
        }
        public double AveragePages()
        {
            return repository.GetBookPages().Average();
           
        }

        public int BiggestBook()
        {
            return repository.GetBookPages().Max();
        }

        public int SmallestBook()
        {
            return repository.GetBookPages().Min();
        }

        public int[] BooksAbove300()
        {
            var result = repository.GetBookPages().Where( n=>n> 300).ToArray();
            return result;
        }
    }

    public class LibraryController
    {
        private readonly LibraryServices services;

        public LibraryController(LibraryServices services)
        {
            this.services = services;
        }

        public void Run()
        {
            char ans;
            do
            {
                Console.WriteLine("Enter the Choice : \n1. TotalBooks \n2. AveragePages \n3. BiggestBook \n4. SmallestBook \n5. BooksAbove300 )");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("Total Book : " + services.TotalBooks());
                        break;
                    case 2: Console.WriteLine("Average Book Pages : " + services.AveragePages());
                        break;
                    case 3: Console.WriteLine("Biggest Book : " + services.BiggestBook());
                        break;
                    case 4: Console.WriteLine("Smallest Book: " + services.SmallestBook());
                        break;
                    case 5: Console.Write("Books above 300 Pages : {");
                        foreach (var n in services.BooksAbove300())
                        {
                            Console.Write(n + " , ");
                        }
                        Console.Write("}");
                        break;
                    default: Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Do You want perform another operation Enter Yes or No");
                ans = Console.ReadLine()[0];

            } while (ans=='y'||ans=='Y');




            //Console.WriteLine("Total Book : " + services.TotalBooks());
            //Console.WriteLine("Average Book Pages : " + services.AveragePages());
            //Console.WriteLine("Biggest Book : " + services.BiggestBook());
            //Console.WriteLine("Smallest Book: " + services.SmallestBook());

            //Console.WriteLine("Books above 300 Pages : {");
            //foreach(var n in services.BooksAbove300())
            //{
            //    Console.Write(n + " , ");
            //}


        }
    }



    //3)------------------------------------------------------------------------------------
    //Assignment 2: Employee Salary System

    public class EmployeeRepository
    {
        public int[] salary = { 15000, 22000, 18000, 35000 };
        public int[] GetSalary()
        {
            return salary;
        }
    }

    public class EmployeeService
    { 
        private readonly EmployeeRepository repository;

        public EmployeeService(EmployeeRepository repository)
        {
            this.repository=repository;
        }

        public int TotalPayout()
        {
            return repository.GetSalary().Sum();
        }
        public int HightSalary()
        {
            return repository.GetSalary().Max();
        }

        public int LowestSalary()
        {
            return repository.GetSalary().Min();
        }

        public int[] EmployeeEarning()
        {
            return repository.GetSalary().Where(n=>n>20000).ToArray();
        }

        public void SalaryRangeCategory()
        {
            var range = repository.GetSalary().GroupBy(n => n > 30000);
            foreach(var n in range )
            {
                Console.WriteLine((n.Key) ? "Greater Than 30000" : "Less than equal to 30000");
                foreach( var n2 in range )
                {
                    Console.Write(n2+" , ");
                }
            }
        }


    }

    public class EmployeeController
    { 
        private readonly EmployeeService service;

        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }

        public void Run()
        {
            char ans;
            do
            {
                Console.WriteLine("Enter Your Choice :\n1. TotalPayout  \n2. HightSalary \n3. LowestSalary \n4. EmployeeEarning \n5. SalaryRangeCategory ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Total PayOut :" + service.TotalPayout());
                        break;
                    case 2:
                        Console.WriteLine("Hight Salary :" + service.HightSalary());
                        break;
                    case 3:
                        Console.WriteLine("Lowest Salary :" + service.LowestSalary());
                        break;
                    case 4:
                        foreach (int n in service.EmployeeEarning())
                        {
                            Console.Write(n + " , ");
                        }
                        break;

                    case 5:
                        service.SalaryRangeCategory();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice ");
                        break;
                }

                Console.WriteLine("Do You want perform another operation Enetr Yes or No");
                ans = Console.ReadLine()[0];

            } while (ans == 'Y' || ans == 'y');


        }
    }




    //==============================================================================================================================

    //1)Exercise 1 — Person HAS-A Address

    public class Address
    { 
        public string Street { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }

        public void GetFullAddress(string street,string city,string pincoad)
        {
            Street = street;
            City = city;
            Pincode = pincoad;
        }
        public override string ToString()
        {
            return $" Street :{Street} City :{City} Pincode :{Pincode}";
        }
    }

    public class Persons
    { 
        public string Name {  get; set; }
        public int Age {  get; set; }
        public Address Address { get; set; }

        public void DisplayProfile( string name,int age,Address address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public override string ToString()
        {
            return $" Name: {Name} , Age :{Age} ,Address:{Address}";
        }
    }



    //----------------------------------------------------------------------

    //2)Exercise 2 — Car HAS-A Engine

    public class Engine
    { 
        public int CC { get; set; }
        public string FuelType {  get; set; }

        public Engine( int cc, string fuel)
        {
            CC=cc;
            FuelType = fuel;
        }

        public void Start()
        {
            Console.WriteLine("The Engine is starting ");
        }

        public void Stop()
        {
            Console.WriteLine("The Engine is Stopping");
        }

        public override string ToString()
        {
            return $"CC : {CC} , Fuel Type :{FuelType}";
        }
    }

    public class Car2
    { 
        public string Brand { get; set; }
        public string Model {  get; set; }
        public Engine Engine { get; set; }

        public Car2(string brand, string model, Engine engine)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
        }

        public void Drive()
        {
            Engine.Start();
            Console.WriteLine("The Car is Starting");
        }

        public void StopCar()
        {
            Engine.Stop();
            Console.WriteLine("The car is stop");
        }

        public override string ToString()
        {
            return $" Brand : {Brand} , Model :{Model} ,Engine : {Engine}  ";
        }


    }

    //---------------------------------------------------------------------------------
   





}
