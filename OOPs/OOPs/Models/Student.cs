using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPs.Models
{
    public class Student
    {
        //27-01-2026
        //Class work

        //Constructor
        //what is Constructor?
        //Constructor is a special method which is used to initialize the object of the class.
        //It is called automatically when an object of the class is created. by using new keyword.

        //types Of Constructor
        //1. Default Constructor: It does not take any parameters and initializes the object with default values.
        //2. Parameterized Constructor: It takes parameters and initializes the object with the values passed as arguments.

        //Constructor Overloading is the process of defining multiple constructors in a class with different parameters.
        ////It allows you to create objects of the class with different initial values.
        //if class does not have constructor then compiler provide Default Constructor
        //if class have Parameterize or default constructor then compiler does not provide any constructor



        private decimal marks;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        //No Argument Constructor (same class name and no return type)
        public Student()
        {
            Id = 101;
            Name = "Maithili";
            Marks = 80;
        }

        //Parameterized Constructor
        public Student(int id, string name, decimal marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }

        //public void DisplayStudent()
        //{
        //    Console.WriteLine($"Student[id : {Id} ,Name : {Name}, Marks : {Marks} ]");

        //}

        public bool IsPass => marks > 35;

        //ToString
        public override string ToString()
        {
            return $"Student[ID :{Id} ,Name:{Name} , Marks:{marks} ]";
        }

    }


    //==============================================================================================================================================
    //27-01-2026
    //Homework 
    //create Constructor and use ToString


    //Person---------------------------------------------------------------------------------
    public class Person
    { 
        private string Name { get; set; }
        private string Address { get; set; }
        private long Phone { get; set; }
        private long AadharNo { get; set; }

        //overloading 
        public Person()
        {
            Name = "Maithili";
            Address = "Akluj";
            Phone = 7840932333;
            AadharNo = 866950026354;
        }

        public Person(string name,string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public override string  ToString()
        {
            return $"[Name: {Name} ,Address: {Address} ,Phone: {Phone} ,AdharNo:  {AadharNo} ]";
        }
        
    }




     //Room--------------------------------------------------------------------------------
     public class Room
    {
        private int RoomNo { get; set; }
        private double Rent { get; set; }
        private string Address { get; set; }

        public Room()
        {
            RoomNo = 1;
            Rent = 15000;
            Address = "Narayan Peth";
        }
        public Room(int roomNo)
        {
            this.RoomNo = roomNo;
        }
        public Room(int roomNo,double rent,string address)
        {
            this.RoomNo = roomNo;
            this.Rent = rent;
            this.Address = address;
        }
        public override string ToString()
        {
            return $"Person :[RoomNo:{RoomNo} ,Rent: {Rent}, Address: {Address}]";
        }

    }

    //Watch-------------------------------------------------------------------------------
    public class Watch
    {
        public string Company { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }

        public Watch()
        {
            Company = "Apple";
            Type = "Smart";
            Price = 34500;

        }

        public override string ToString()
        {
            return $"Watch :[Company:{Company} ,Type : {Type}, Price: {Price}]";
        }


    }

    //Book--------------------------------------------------------------------------------
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book()
        {
            Name = "Can we be strengers again?";
            Author = "Shrijeet Shandilya";
            Price = 250;
        }

        public Book(string name, string author, double price)
        {
            Name = name;
            Author = author;
            Price = price;
        }

        public Book(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Book [ Name :{Name} ,Author :{Author} ,Price :{Price} ]";
        }
     }


    //Account-----------------------------------------------------------------------------
    public class Account
    {
        public string Name { get; set; }
        public long AccountNo { get; set; }
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public string BankName { get; set; }

        public Account()
        {
            Name = "Tanaji Pise";
            AccountNo = 4235879090005;
            balance = 1000000;
            BankName = "SBI";
        }
        public Account(string name,long accountNo,double balance,string bankName)
        {
            Name = name;
            AccountNo = accountNo;
            Balance = balance;
            BankName = bankName;

        }
        public Account(string name, double balance, string bankName)
        {
            Name = name;
            Balance = balance;
            BankName = bankName;

        }
        public Account(string bankName,string name, long accountNo, double balance)
        {
            Name = name;
            AccountNo = accountNo;
            Balance = balance;
            BankName = bankName;

        }
        //public override string ToString()
        //{
        //    return base.ToString(); //This is return only class name
        //}
        public override string ToString()
        {
            return $"account:[name :{Name} , BankName :{BankName} , AccountNo :{AccountNo} , Balance :{Balance} ]";
        }

    }



    // MObile-----------------------------------------------------------------------------
    public class Mobile
    {
        public string Brand { get; set; }
        public double Price { get; set; }
        public int RAM { get; set; }
        public int ROM { get; set; }

        public Mobile()
        {
            Brand = "Oneplus";
            Price = 35000;
            RAM = 8;
            ROM = 512;

        }
        public override string ToString()
        {
            return $"Mobile [Brand :{Brand} , Price : {Price} ,RAM :{RAM} ,ROM: {ROM} ]";
        }


    }

    //Laptop------------------------------------------------------------------------------
    public class Laptop
    {
        public string Company{ get; set; }
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }

        public Laptop()
        {
            Company = "HP";
            Processor = "intel i5";
            RAM = 16;
            Storage = 512;
        }
        public override string ToString()
        {
            return $"[Company:{Company} ,Processor :{Processor}, RAM: {RAM}, Storage:{Storage}]";
        }
    }

    //Circle------------------------------------------------------------------------------
    public class Circle
    {
        public double Redius { get; set; }

        public Circle(double redius)
        {
            Redius = redius;
        } 
        public Circle()
        {
            Redius = 2;
        }
        public override string ToString()
        {
            return $"Redis of Circle is : {Redius} \nArea of Circle is :{3.14 * Redius * Redius} ";
        }
    }

    //Movie---------------------------------------------------------------------------------
    public class Movie
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public double Collection { get; set; }

        public Movie()
        {
            Name = "3 Idiots";
            Director = "Rajkumar Hirani";
            Collection = 2000000000;
        }

        public override string ToString()
        {
            return $"Movie :[Movie Name :{Name} , Director :{Director}, Collection :{Collection} ]";
        }

    }

    //Country------------------------------------------------------------------------------
    public class Country
    {
        public string Name { get; set; }
        public  int Population { get; set; }
        public string Capital { get; set; }

        public Country()
        {
            Name = "India";
            Population = 1250000000;
            Capital = "Delhi";
        }
        public Country(string name, int population, string capital)
        {
            Name = name;
            Population = population;
            Capital = capital;
        }
        public override string ToString()
        {
            return $"Country [Name :{Name} , Capital :{ Capital} , Population :{Population} ]";
        }
     }

    //Company------------------------------------------------------------------------------
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int EmployeeCount { get; set; }

        public Company()
        {
            Id = 101;
            Name = "TCS";
            Location = "Mumbai";
            EmployeeCount = 6000000;
        }

        public Company(int id, string name, string location, int employeeCount)
        {
            Id = id;
            Name = name;
            Location = location;
            EmployeeCount = employeeCount;
        }

        public Company(string name,string location ,int employeeCount)
        {
            Id = 102;
            Name = name;
            Location = location;
            EmployeeCount = employeeCount;
        }

        public override string ToString()
        {
            return $"Company[ ID:{Id} ,Name :{Name} ,Location :{Location} ,EmployeeCount :{EmployeeCount} ]";
        }
     }

    //Bike---------------------------------------------------------------------------------
    public class Bike
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public string Color { get; set; }

        public Bike()
        {
            Name = "Royal Enfield Classic 350";
            Brand = "Royal Enfield";
            Price = 200000;
            Color = "Black";
        }
        public Bike(string name, string brand, double price, string color)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Color = color;
        }

        public override string ToString()
        {
            return $"Name:{Name} ,Brand:{Brand} ,Price:{Price} ,Color:{Color}";
        }
    }

    //========================================================================================================================================================================
    ////28-01-2026
    //Class work 

    //what is Constructor Chaining in C#
    // Constructor chaining is a technique in C# where one constructor calls another constructor within the same class or a base class.
    //// This allows for code reuse and can help to avoid duplication of initialization logic.
    
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee() :this(1,"Maithili",54000)
        {
            Console.WriteLine("zero parameterized Constructor");
        }
        public Employee(int id,string name,double salary):this(name,salary)
        {
            Id = id;
            Console.WriteLine("1st parametrized Constructor");
        }
        public Employee(string name,double salary):this(salary)
        {
            Name = name;
            Console.WriteLine("2nd parametrized Constructor");
        }
        public Employee(double salary)
        {
            Salary = salary;
            Console.WriteLine("3rd parametrized Constructor");
        }

        public override string ToString()
        {
            return $"ID :{Id} , Name: {Name} , Salary:{Salary}";
        }
    }

    //practice question 
    public class User
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public User()
        {
            Console.WriteLine("Default Constructor");
        }
        public User(int id):this()
        {
            ID = id;
            Console.WriteLine($"Id :{ ID}");
        }
        public User(int id ,string name) : this(104)
        {
            ID = id;
            Name = name;
            Console.WriteLine($"Id :{ID} ,name is {Name}");
        }
        public User(int id, string name ,int age) : this(id,"gayatri")
        {
            ID = id;
            Name = name;
            Age = age;
            Console.WriteLine($"Id :{ID} ,name is {Name} ,Age is {Age}");
        }
    }



}