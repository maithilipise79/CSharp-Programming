using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
    //public class Person
    //{
    //    private string Name { get; set; }
    //    private string Address { get; set; }
    //    private long Phone { get; set; }
    //    private long AadharNo { get; set; }

    //    //overloading 
    //    public Person()
    //    {
    //        Name = "Maithili";
    //        Address = "Akluj";
    //        Phone = 7840932333;
    //        AadharNo = 86695050054;
    //    }

    //    public Person(string name, string address)
    //    {
    //        this.Name = name;
    //        this.Address = address;
    //    }

    //    public override string ToString()
    //    {
    //        return $"[Name: {Name} ,Address: {Address} ,Phone: {Phone} ,AdharNo:  {AadharNo} ]";
    //    }

    //}




    ////Room--------------------------------------------------------------------------------
    //public class Room
    //{
    //    private int RoomNo { get; set; }
    //    private double Rent { get; set; }
    //    private string Address { get; set; }

    //    public Room()
    //    {
    //        RoomNo = 1;
    //        Rent = 15000;
    //        Address = "Narayan Peth";
    //    }
    //    public Room(int roomNo)
    //    {
    //        this.RoomNo = roomNo;
    //    }
    //    public Room(int roomNo, double rent, string address)
    //    {
    //        this.RoomNo = roomNo;
    //        this.Rent = rent;
    //        this.Address = address;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Person :[RoomNo:{RoomNo} ,Rent: {Rent}, Address: {Address}]";
    //    }

    //}

    ////Watch-------------------------------------------------------------------------------
    //public class Watch
    //{
    //    public string Company { get; set; }
    //    public string Type { get; set; }
    //    public double Price { get; set; }

    //    public Watch()
    //    {
    //        Company = "Apple";
    //        Type = "Smart";
    //        Price = 34500;

    //    }

    //    public override string ToString()
    //    {
    //        return $"Watch :[Company:{Company} ,Type : {Type}, Price: {Price}]";
    //    }


    //}

    ////Book--------------------------------------------------------------------------------
    //public class Book
    //{
    //    public string Name { get; set; }
    //    public string Author { get; set; }
    //    public double Price { get; set; }

    //    public Book()
    //    {
    //        Name = "Can we be strengers again?";
    //        Author = "Shrijeet Shandilya";
    //        Price = 250;
    //    }

    //    public Book(string name, string author, double price)
    //    {
    //        Name = name;
    //        Author = author;
    //        Price = price;
    //    }

    //    public Book(string name, double price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Book [ Name :{Name} ,Author :{Author} ,Price :{Price} ]";
    //    }
    //}


    ////Account-----------------------------------------------------------------------------
    //public class Account
    //{
    //    public string Name { get; set; }
    //    public long AccountNo { get; set; }
    //    private double balance;
    //    public double Balance
    //    {
    //        get { return balance; }
    //        set { balance = value; }
    //    }
    //    public string BankName { get; set; }

    //    public Account()
    //    {
    //        Name = "Tanaji Pise";
    //        AccountNo = 4235879090005;
    //        balance = 1000000;
    //        BankName = "SBI";
    //    }
    //    public Account(string name, long accountNo, double balance, string bankName)
    //    {
    //        Name = name;
    //        AccountNo = accountNo;
    //        Balance = balance;
    //        BankName = bankName;

    //    }
    //    public Account(string name, double balance, string bankName)
    //    {
    //        Name = name;
    //        Balance = balance;
    //        BankName = bankName;

    //    }
    //    public Account(string bankName, string name, long accountNo, double balance)
    //    {
    //        Name = name;
    //        AccountNo = accountNo;
    //        Balance = balance;
    //        BankName = bankName;

    //    }
    //    //public override string ToString()
    //    //{
    //    //    return base.ToString(); //This is return only class name
    //    //}
    //    public override string ToString()
    //    {
    //        return $"account:[name :{Name} , BankName :{BankName} , AccountNo :{AccountNo} , Balance :{Balance} ]";
    //    }

    //}



    //// MObile-----------------------------------------------------------------------------
    //public class Mobile
    //{
    //    public string Brand { get; set; }
    //    public double Price { get; set; }
    //    public int RAM { get; set; }
    //    public int ROM { get; set; }

    //    public Mobile()
    //    {
    //        Brand = "Oneplus";
    //        Price = 35000;
    //        RAM = 8;
    //        ROM = 512;

    //    }
    //    public override string ToString()
    //    {
    //        return $"Mobile [Brand :{Brand} , Price : {Price} ,RAM :{RAM} ,ROM: {ROM} ]";
    //    }


    //}

    ////Laptop------------------------------------------------------------------------------
    //public class Laptop
    //{
    //    public string Company { get; set; }
    //    public string Processor { get; set; }
    //    public int RAM { get; set; }
    //    public int Storage { get; set; }

    //    public Laptop()
    //    {
    //        Company = "HP";
    //        Processor = "intel i5";
    //        RAM = 16;
    //        Storage = 512;
    //    }
    //    public override string ToString()
    //    {
    //        return $"[Company:{Company} ,Processor :{Processor}, RAM: {RAM}, Storage:{Storage}]";
    //    }
    //}

    ////Circle------------------------------------------------------------------------------
    //public class Circle
    //{
    //    public double Redius { get; set; }

    //    public Circle(double redius)
    //    {
    //        Redius = redius;
    //    }
    //    public Circle()
    //    {
    //        Redius = 2;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Redis of Circle is : {Redius} \nArea of Circle is :{3.14 * Redius * Redius} ";
    //    }
    //}

    ////Movie---------------------------------------------------------------------------------
    //public class Movie
    //{
    //    public string Name { get; set; }
    //    public string Director { get; set; }
    //    public double Collection { get; set; }

    //    public Movie()
    //    {
    //        Name = "3 Idiots";
    //        Director = "Rajkumar Hirani";
    //        Collection = 2000000000;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Movie :[Movie Name :{Name} , Director :{Director}, Collection :{Collection} ]";
    //    }

    //}

    ////Country------------------------------------------------------------------------------
    //public class Country
    //{
    //    public string Name { get; set; }
    //    public int Population { get; set; }
    //    public string Capital { get; set; }

    //    public Country()
    //    {
    //        Name = "India";
    //        Population = 1250000000;
    //        Capital = "Delhi";
    //    }
    //    public Country(string name, int population, string capital)
    //    {
    //        Name = name;
    //        Population = population;
    //        Capital = capital;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Country [Name :{Name} , Capital :{Capital} , Population :{Population} ]";
    //    }
    //}

    ////Company------------------------------------------------------------------------------
    //public class Company
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Location { get; set; }
    //    public int EmployeeCount { get; set; }

    //    public Company()
    //    {
    //        Id = 101;
    //        Name = "TCS";
    //        Location = "Mumbai";
    //        EmployeeCount = 6000000;
    //    }

    //    public Company(int id, string name, string location, int employeeCount)
    //    {
    //        Id = id;
    //        Name = name;
    //        Location = location;
    //        EmployeeCount = employeeCount;
    //    }

    //    public Company(string name, string location, int employeeCount)
    //    {
    //        Id = 102;
    //        Name = name;
    //        Location = location;
    //        EmployeeCount = employeeCount;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Company[ ID:{Id} ,Name :{Name} ,Location :{Location} ,EmployeeCount :{EmployeeCount} ]";
    //    }
    //}

    ////Bike---------------------------------------------------------------------------------
    //public class Bike
    //{
    //    public string Name { get; set; }
    //    public string Brand { get; set; }
    //    public double Price { get; set; }

    //    public string Color { get; set; }

    //    public Bike()
    //    {
    //        Name = "Royal Enfield Classic 350";
    //        Brand = "Royal Enfield";
    //        Price = 200000;
    //        Color = "Black";
    //    }
    //    public Bike(string name, string brand, double price, string color)
    //    {
    //        Name = name;
    //        Brand = brand;
    //        Price = price;
    //        Color = color;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Name:{Name} ,Brand:{Brand} ,Price:{Price} ,Color:{Color}";
    //    }
    //}

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

        public Employee() : this(1, "Maithili", 54000)
        {
            Console.WriteLine("zero parameterized Constructor");
        }
        public Employee(int id, string name, double salary) : this(name, salary)
        {
            Id = id;
            Console.WriteLine("1st parametrized Constructor");
        }
        public Employee(string name, double salary) : this(salary)
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
        public User(int id) : this()
        {
            ID = id;
            Console.WriteLine($"Id :{ID}");
        }
        public User(int id, string name) : this(104)
        {
            ID = id;
            Name = name;
            Console.WriteLine($"Id :{ID} ,name is {Name}");
        }
        public User(int id, string name, int age) : this(id, "gayatri")
        {
            ID = id;
            Name = name;
            Age = age;
            Console.WriteLine($"Id :{ID} ,name is {Name} ,Age is {Age}");
        }
    }
    //================================================================================================================================================================

    //31/1/2026
    //copy constructor

    //public class Student1
    //{ 
    //    public int ID { get; set; }
    //    public string Name {  get; set; }

    //    public Student1(int id,string name)
    //    {
    //        ID = id;
    //        Name = name;
    //    }
    //    public Student1(Student1 s)
    //    {
    //        ID = s.ID;
    //        Name =s.Name;
    //    }

    //    public override string ToString()
    //    {
    //        return $"ID :{ID} Name:{Name}";
    //    }
    //}







    //=====================================================================================================================================================================
    //02/02/2003
    //Homework

    //Q1.Default Constructor
    //Create a class AdminUser with properties AdminId, Name, and IsActive.
    //The default constructor should set IsActive = true.
    //Create an object and print the IsActive value.


    public class AdminUser
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public AdminUser()
        {
            AdminId = 101;
            Name = "Maithili";
            IsActive = true;
        }

    }



    //Q2. Parameterized Constructor
    //Create a class LoginSession with AdminId and LoginTime.
    //Initialize values using parameterized constructor and print login details


    public class LoginSession
    {
        public int AdminId { get; set; }
        public int Time { get; set; }

        public LoginSession(int adminId, int time)
        {
            AdminId = adminId;
            this.Time = time;
        }

        public override string ToString()
        {
            return $"AdminId :{AdminId}  Time :{Time}";
        }
    }


    //PART 2: OVERLOADING & this KEYWORD


    //Q3. Constructor Overloading
    //Create a class UserProfile with Name, Age, and City.
    //Create three constructors:
    //1. Name only
    //2. Name and Age
    //3. Name, Age, and City
    //Create objects using all constructors and print details

    //public class UserProfile
    //{
    //    public string Name { get; set; } = "maithilii";
    //    public int Age { get; set; }
    //    public string City { get; set; } = "Akluj";


    //    public UserProfile(string name)
    //    {
    //        this.Name = name;
    //    }
    //    public UserProfile(string name, int age ) 
    //    {
    //        this.Name= name;
    //        this.Age = age;

    //    }
    //    public UserProfile(string name, int age, string city) 
    //    {
    //        Name = name;
    //        Age = age;
    //        City = city;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Name :{Name}  , Age :{Age} , City :{City}";
    //    }
    //}



    //Q4.Constructor Chaining using this
    //Modify UserProfile constructors so that:- Second constructor calls first using this- Third constructor calls second using this
    //Avoid duplicate code.

    public class UserProfile
    {
        public string Name { get; set; } = "maithilii";
        public int Age { get; set; }
        public string City { get; set; } = "Akluj";


        public UserProfile(string name)
        {
            this.Name = name;
        }
        public UserProfile(string name, int age) :this("gayatri")
        {
            
            this.Age = age;

        }
        public UserProfile(string name, int age, string city) :this(name,age)
        {
          
            City = city;
        }

        public override string ToString()
        {
            return $"Name :{Name}  , Age :{Age} , City :{City}";
        }
    }

    //PART 3: INHERITANCE & base KEYWORD

    //Q5.Constructor Chaining using base
    //Create a base class Admin with constructor accepting Name.
    //Create derived class SuperAdmin with constructor accepting Name and PermissionLevel.
    //Use base keyword to call parent constructor and print details




    //PART 4: ADVANCED CONSTRUCTORS
    //Q6.Private Constructor
    //Create a class AdminConfig with a private constructor and a static property AppName.
    //Explain why private constructor is used and mention real-time use case.
    public class AdminConfig
    {
        //public static string AppName { get; set; }
        public  string AppName { get; set; }

        private AdminConfig()
        {
            AppName = "Instagram";
        }

        public static AdminConfig CreateObject()
        {
            return new AdminConfig();
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public double Price { get; set; }

        private Car(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public static Car CreateObject( string name,double value)
        {
            return new Car( name,value);
        }

    }





    //Q7.Constructor vs Static Constructor
    //Create a class AppSettings with:- Static constructor initializing ApplicationName- Normal constructor initializing Environment
    //Print both values and explain execution order.
    public class AppSetting
    {
        public static string ApplicationName { get; set; }
        public string Environment { get; set; }
         static AppSetting()
        {
            ApplicationName = "Instagram";
            Console.WriteLine("I am static constructor ");
        }
        public AppSetting()
        {
            Environment = " friendly ";
            Console.WriteLine("I am Normal Constuctor");
        }

        public override string ToString()
        {
            return $"application Name:{ApplicationName}  Environment :{Environment} ";
        }
    }



    //Q8.Singleton Pattern using Constructor
    //Create a Singleton class using private constructor, static instance, and public static property.
    //Mention real-time use case (cache, configuration, logger).




    //========================================================================================================================================================================
    //02/02/2003
    //Class work 

    //Static Purpose
    //what is static 
    //static keyword is used to declare static members
    //static members belong to the class itself rather than to any specific instance
    //static members are shared across all instances of the class
    //purpose of static members is to provide functionality or data that is common to all instances of the class

    //just chack if filed is static then how to work // and find out the how many times create the object for the class


    //public class Sparrow
    //{

    //    public int count = 0;    // when we increment in constructor thats not affected here for each time count=0;x=0;
    //    public int x = 0;       // its instance variable that why its take memory in obj and it is part of object

    //    public Sparrow()
    //    {
    //        count++;
    //        x++;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Count :{count} , x :{x}";
    //    }


    //}

    public class Sparrow1
    {
        public static int count = 0; //change//it is static because of that its membar of class(take memory only once in stack)
        public int x = 0;            //not changes

        public Sparrow1()
        {
            count++;
            x++;
        }

        public override string ToString()
        {
            return $"Count :{count} , x :{x}";
        }

    }
    public class Sparrow2
    {
        public static int count = 0;  
        public static int x = 0;           

        public Sparrow2()
        {
            count++;
            x++;
        }

        public override string ToString()
        {
            return $"Count :{count} , x :{x}";
        }

    }

    //Static Constructor
    public class Sparrow3
    { 
        public static int count = 0;
        public int y = 0;

        static Sparrow3()
        {
            count++;
        }

        public override string ToString()
        {
            return $" Count: {count} ";
        }
    }

    public class Sparrow4
    {
        public static int count = 0;
        public static int y = 0;

        static Sparrow4()
        {
            count++;
        }

        public Sparrow4()
        {
            y++;
        }
        public override string ToString()
        {
            return $"count : {count}  Y :{y}";
        }
    }

    class Example
    {
        public static int count;
        public int x;

        static Example()
        {
            count = 50;
            Console.WriteLine("Static constructor called");
        }

        public Example()
        {
            x = ++count;
        }

        public override string ToString()
        {
            return $"Count: {count}, X: {x}";
        }
    }





    //===========================================================================================================================================
    //04/02/2026
    //homework
    //Static Method vs Instance Method 

    //Exercise 1: Identify Static vs Instance
    //Given a Calculator class with Add and Multiply methods.Decide whether these methods should be
    //static or instance methods and explain why.
    public class Calculator
    { 
        public static void Add(int a,int b)
        {
            Console.WriteLine($"{a} + {b} => {a + b}");
        }
        public static void Substract(int a,int b)
        {
            Console.WriteLine($"{a} - {b} => {a - b}");
        }
        public static void Mult(int a,int b)
        {
            Console.WriteLine($"{a} * {b} => {a * b}");
        }
    }




    //Exercise 2: Convert Static to Instance
    //A User class has a Name property.Modify a static greeting method so that it uses the user's name.
    //Decide whether the method should be static or instance.

    public class User1 { 
        public static string Name { get; set; }

        public static string Greeting()
        {
            return $"Good Morning {Name}";
        }
    }

    //Exercise 3: Utility vs Behavior
    //An EmailService class has methods for sending email and validating email format.Identify which
    //method should be static and which should be instance, with reasoning.

    public class EmailServices
    { 
        public static bool EmailValidation(string email)
        {
            bool isValid = email.Contains("@");
            
            return isValid;
        }

        public void SendEmail(string email,string subject,string body)
        {
            if (EmailValidation(email)==true)
            {
                Console.WriteLine($"To :{email}");
                Console.WriteLine($"Subject :{subject}");
                Console.WriteLine($"Body :{body}");
            }
            else
            {
                Console.WriteLine("Email is Invalid");
            }
        }
    }


    //Exercise 4: Static Variable Counter
    //A class contains a static counter incremented in the constructor.Create multiple objects and predict
    //the output

    public class CountObj
    {
        public static int count = 0;

        public CountObj()
        {
            count++;
        }

    }


    //Exercise 5: Fix the Compilation Error
    //A static method tries to access an instance variable.Identify the error and fix it using two different
    //approaches

    //ans => id method is static then its not able to access instance varible
    //to solve this there are two approach
    //1.make variable static 
    //2.make method instance

    public class Solution
    {
        public static string name="maithili";

        static Solution()
        {
            Console.WriteLine("Hello " + name);
        }
    }
    public class Solution1
    {
        public string name="maithili";

        public Solution1()
        {
            Console.WriteLine("Hello " + name);
        }
    }


   


   




}
