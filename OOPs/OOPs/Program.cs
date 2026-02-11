using OOPs.Models;
using OOPs.Polymorphism.MethodOverloading.BasicsLevelProblem;
using OOPs.Polymorphism.MethodOverloading.IntermediateLevelProblem;
using OOPs.Polymorphism.MethodOverloading.AdvancedLevelProblem;
using System;
using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPs
{

    //========================================================================= Class and Object ===============================================================================


    //OOPs
    //what is OOPs?
    //OOPs is a programming paradigm that uses objects and classes to structure code
    //OOPs stands for Object Oriented Programming
    //OOPs is based on four main principles: Encapsulation, Inheritance, Polymorphism and Abstraction
    //OOPs allows code reusability, modularity and maintainability
    //OOPs is widely used in modern programming languages like C#, Java, Python, C++ etc.
    //OOPs helps to model real world entities and their behavior in code
    //OOPs promotes code organization and readability

    //Class
    //what is class?
    //class is a user defined data type which contains data members and member functions
    //class is a blueprint or template from which we can create multiple objects
    //class is a logical entity that represents real world entity 
    //class is a collection of related data members and member functions
    //class is a way to bind data and functions together
    //class is a way to achieve encapsulation in OOPs
    //class does not occupy memory
    //class is defined using class keyword
    //how to define a class?



    //Class Employee
    //public class Employee
    //{
    //    public int id = 101;
    //    public string name = "Maithili";
    //    public decimal salary = 130000;

    //    public decimal IncrementSalary(double per)
    //    {
    //        salary = salary + (salary * (decimal)(per / 100));
    //        return salary;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"Employee Id : {id}");
    //        Console.WriteLine($"Employee Name: {name}");
    //        Console.WriteLine($"Employee Salary : {salary}");
    //        

    //    }

    //}

    //Class Student-----------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class Student
    //{
    //    //public string name = "Maithili";
    //    //public int rollNo = 1;
    //    //public string address = "Akluj";
    //    //public string course = "BE";
    //    //public float percentage = 84.40f;


    //    //public void StudentDetails()
    //    //{
    //    //    Console.WriteLine("Student Name : " + name);
    //    //    Console.WriteLine("Student Roll No :" + rollNo);
    //    //    Console.WriteLine("Address : " + address);
    //    //    Console.WriteLine("Course Name : " + course);
    //    //    Console.WriteLine("Percentage : " + percentage);
    //    //}
    //    //public string Result()
    //    //{
    //    //    string result = (percentage >= 35) ? "Pass" : "Fail";
    //    //    return result;
    //    //}



    //    //private filed for getter and setter 
    //    private string name = "Maithili";

    //    public void SetName(string name) //traditional Way(using method)
    //    {
    //        this.name = name;  //this refers to the current object of the class.
    //                           //It is used inside a class to differentiate between fields and parameters when they have the same name.
    //    }
    //    public string GetName()
    //    {
    //        return name;
    //    }
    //}



    //Class College--------------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class College
    //{
    //    private int id = 123;
    //    public string name = "SMM,Akluj";
    //    public string address = "Akluj";
    //    public string AffiliatedUniversity = "SPPU";
    //    public int totalDepartment = 6;
    //    //public string email = "smm54757@gmail.com";
    //    private string email = "smm54757@gmail.com";

    //    //Using properties (manual get/set)
    //    public string Email
    //    {
    //        get { return email; }
    //        set { email = value; } //here value is keyword
    //    }
    //    public int ID
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }


    //    public void CollegeDetails()
    //    {
    //        Console.WriteLine("College ID : " + id);
    //        Console.WriteLine("College Name : " + name);
    //        Console.WriteLine("College Address : " + address);
    //        Console.WriteLine("Affiliated University : " + AffiliatedUniversity);
    //        Console.WriteLine("College Email : " + email);
    //    }

    //}



    //Class Watch------------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class Watch
    //{
    //public double price = 20000;
    //public string company = "Titan";
    //public string type = "Analog";

    // Auto-implemented property (simplest form)
    //    public  double Price{get; set;}
    //    public string Company { get; set; }
    //    public string Type { get; set; } = "Analog"; //if u want set default value


    //    public void WatchDetails()
    //    {
    //        Console.WriteLine($"Watch Details: \nType : {Type}\nCompany:{Company}\nPrice : {Price} ");

    //    }
    //    public double ApplyTax(double percentage)
    //    {
    //        if (Price >= 50000)
    //        {
    //            Price = Price + (Price * (percentage / 100));
    //            return Price;
    //        }
    //        else
    //        {
    //            Console.WriteLine("price of watch is less than 50000 becuse of that tax not appay");
    //            return Price;
    //        }
    //    }

    //}

    //Class Mobile------------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class Mobile
    //{
    //    public string company = "Apple";
    //    public string model = "iphone 16 ProMax";
    //    public string color = "Gray";
    //    //public int storage = 256;
    //    //public double price = 80000;

    //    public int Storage { get; set; }
    //    public double Price { get; set; }



    //    public void DisplayMobileDetails()
    //    {
    //        Console.WriteLine("Company : " + company);
    //        Console.WriteLine("Model : " + model);
    //        Console.WriteLine("Color : " + color);
    //        //Console.WriteLine("Storage : " + storage + " GB");
    //        //Console.WriteLine("Price : rs." + price);
    //        Console.WriteLine("Storage : " + Storage + " GB");
    //        Console.WriteLine("Price : rs." + Price);
    //    }


    //    //public void ApplyDiscount(double discountPercent)
    //    //{
    //    //    price = price - (price * discountPercent / 100);
    //    //    Console.WriteLine("Price after discount : rs." + price);
    //    //}


    //}

    //Laptop-------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class Laptop
    //{
    //    //public string brand = "HP";
    //    //public string processor = "intel i5";
    //    //public int ram = 8;
    //    //public int storage = 512;
    //    public string Brand { get; set; }
    //    public string Processor { get; set; }
    //    public int Ram { get; set; }
    //    public int Storage { get; set; }

    //    public  void DisplayInfo()
    //    {
    //        //Console.WriteLine("Brand = " + brand);
    //        //Console.WriteLine("Processor = " + processor);
    //        //Console.WriteLine("RAM = " + ram);
    //        //Console.WriteLine("Storage = " + storage);
    //        Console.WriteLine("Brand = " + Brand);
    //        Console.WriteLine("Processor = " + Processor);
    //        Console.WriteLine("RAM = " + Ram);
    //        Console.WriteLine("Storage = " + Storage);

    //    }
    //    //public string CheckPerformance()
    //    //{
    //    //    string result = (ram < 8) ? "Low" : (ram == 8) ? "Medium" : (ram >= 16) ? "High":"Something went wrong ";
    //    //    return result;
    //    //}

    //}


    ////Class Table----------------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class Table
    //{
    //    public int length = 60;
    //    public int width = 60;
    //   // public string material = "wooden";
    //    public double price = 30000;

    //    public string Material { get; set; } = "wooden";

    //    public void Display()
    //    {
    //        Console.WriteLine("Length of table :" + length);
    //        Console.WriteLine("Width of table :" + width);
    //        Console.WriteLine("Material of table :" + Material);
    //        Console.WriteLine("Price of table :" + price);
    //    }

    //    public double ApplyDiscount(double discount)
    //    {
    //        price = price - (price *(discount / 100));
    //        return price;
    //    }

    //}

    //Class Product----------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class Product
    //{
    //    //public int productID = 1;
    //    private int productID; //here this filed is private
    //    public string productName = "Mobile";
    //    public string brand = "Apple";
    //    public string category = "Electronics";
    //    public double price = 120000;
    //    public int stock = 30;

    //    //here we use property(manualy)
    //    public int ProductID
    //    {
    //        get { return productID; }
    //        set { productID = value; }
    //    }


    //    public void Display()
    //    {
    //        Console.WriteLine("Product ID : " + productID);
    //        Console.WriteLine("Product Name : " + productName);
    //        Console.WriteLine("Product Brand : " + brand);
    //        Console.WriteLine("Product Category : " + category);
    //        Console.WriteLine("Product prie : " + price);
    //        Console.WriteLine("Product stock : " + stock);


    //    }

    //    public string CkeckStock(int requirement)
    //    {
    //        string result = (requirement > stock) ? "Stock Available" : "Stock Unavilable";
    //        return result;
    //    }
    //}


    //Class Customer-----------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class Customer
    //{
    //    //public int customerID = 101;
    //    //public string email = "maithili2003@gmail.com";
    //    //public long mobileNo = 7840933333;
    //    //public string address = "akluj";
    //    public int CustomerID { get; set; }
    //    public string Email { get; set; }
    //    public long MobileNo { get; set; }
    //    public string Address { get; set; }

    //    public void ViewInfo()
    //    {
    //        //Console.WriteLine("Customer ID : " + customerID);
    //        //Console.WriteLine("Email : " + email);
    //        //Console.WriteLine("Mobile Number :" + mobileNo);
    //        //Console.WriteLine("Address : " + address);
    //        Console.WriteLine("Customer ID : " + CustomerID);
    //        Console.WriteLine("Email : " + Email);
    //        Console.WriteLine("Mobile Number :" + MobileNo);
    //        Console.WriteLine("Address : " + Address);

    //    }
    //}


    //Class Invoice--------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //public class Invoice
    //{
    //    private string  invoiceNo = "INV-101";
    //    public string customerName = "Maithili Pise";
    //    public string productName = "Mobile";
    //    public int quantity = 2;
    //    public string paymentMethod = "cash";
    //    //public double price = 60000;

    //    public double Price { get; set; } = 120000;


    //    public string InvoiceNo
    //    {
    //       get { return invoiceNo; }
    //       set { invoiceNo = value; }

    //    }

    //    public void DisplayInvoiceDetails()
    //    {
    //        Console.WriteLine("Invoice Number : " + invoiceNo);
    //        Console.WriteLine("Customer Name : " + customerName);
    //        Console.WriteLine("Product Name : " + productName);
    //        Console.WriteLine("quantity : " + quantity);
    //        //Console.WriteLine("Price : " + price);
    //        Console.WriteLine("Price : " + Price);
    //        Console.WriteLine("paymentMethod : " + paymentMethod);

    //    }
    //    //public double TotalAmount()
    //    //{
    //    //    double total = quantity * price;
    //    //    return total;
    //    //}


    //}



    //=========================================================================================================================================================================================



    //public class Program
    //{

    //    public static void Main(string[] args)
    //    {
    //22/01/2026
    //Class Work

    //Object
    //what is object?
    //object is an instance of a class
    //object is a physical entity that occupies memory
    //object is created using new keyword
    //object is used to access data members and member functions of a class
    //object is created in heap memory
    //multiple objects can be created from a single class
    //each object has its own copy of data members
    //object is used to achieve polymorphism in OOPs
    //object is used to achieve inheritance in OOPs
    //object is independent of other objects
    //object is created at runtime
    //object is instance of a class




    //Employee emp1 = new Employee();
    //emp1.Display();  //Display predefined value
    //emp1.id = 1001;    //update value by using ref(object)
    //emp1.name = "Maithili.pise";
    //emp1.salary = 150000;
    //emp1.Display();    //display updated value


    // create one more onject for same class  which takes separet memory in heap
    //Employee emp2 = new Employee();
    //emp2.Display();  //display predefine value
    //emp2.id = 1002;
    //emp2.name = "Shivtej Pise";

    //now we use methos/function to increment salary
    //int percentage=10;
    //emp1.IncrementSalary(percentage);

    //emp1.Display();

    //==================================================================================================================================================================================

    //Homework
    //22/01/2026
    //just create object .and call function(all are public)and update data


    //==== for Class student ====
    //Student s1 = new();  //we can create obj also like that 
    //s1.StudentDetails();
    //string result = s1.Reasult();
    //Console.WriteLine("Student result : " + result);
    //s1.percentage = 31;
    //s1.StudentDetails();
    //result = s1.Reasult();
    //Console.WriteLine("Student result : " + result);
    //Student s2 = new();
    //s2.rollNo = 21;
    //s2.name = "Shivtej Pise";
    //s2.course = "Civil Engg.";
    //s2.percentage = 89;
    //s2.StudentDetails();
    //Console.WriteLine("Student result : " + s2.Reasult());



    //==== for Class College ====
    //College smm = new();
    //smm.CollegeDetails();
    //College svpm = new();
    //svpm.id = 101;
    //svpm.name = "SVPM College of Engineering";
    //svpm.email = "svpm@gmail.com";
    //svpm.address = "Baramati";
    //svpm.totalDepartment = 6;
    //svpm.AffiliatedUniversity = "sppu";
    //svpm.CollegeDetails();



    //==== for Class Watch ====
    //Watch obj1 = new();
    //obj1.WatchDetails();
    //Console.WriteLine("Price of watch after applaying tax :"+ obj1.ApplyTax(10));
    //Console.WriteLine("\n");
    //Watch obj2 = new();
    //obj2.price = 100000;
    //obj2.company = "Apple";
    //obj2.type = "Digital";
    //obj2.WatchDetails();
    //Console.WriteLine("Price of watch after applaying tax :" + obj2.ApplyTax(10));



    //====for Class Mobile ==== 
    //Mobile mob1 = new();
    //mob1.DisplayMobileDetails();
    //mob1.ApplyDiscount(10);
    //Mobile mob2 = new();
    //mob2.model = "S24-ultra";
    //mob2.company = "Samsung";
    //mob2.price = 115000;
    //mob2.color = "black";
    //mob2.DisplayMobileDetails();
    //mob2.ApplyDiscount(15);



    //==== for Class Laptop ====
    //Laptop l1 = new();
    //l1.DisplayInfo();
    //Console.WriteLine("Performance = " + l1.CheckPerformance());
    //l1.ram = 16;
    //l1.DisplayInfo();
    //Console.WriteLine("Performance = " + l1.CheckPerformance());



    //==== for Class Table ====
    //Table t1 = new Table();
    //t1.Display();
    //Table t2 = new();
    //t2.material = "glass";
    //t2.price = 15000;
    //t2.Display();
    //Console.WriteLine("Price of Table after applaying discount : " + t2.ApplyDiscount(10));
    //t2.Display();



    //==== for Class Product ====
    //Product p1 = new();
    //p1.Display();
    //Console.WriteLine("Enter your requirement :");
    //int item = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine(p1.CkeckStock(item));
    //Console.WriteLine("\n");
    //Product p2 = new();
    //p2.brand = "Allen Solly";
    //p2.productName = "Shirt";
    //p2.price = 2500;
    //p2.productID = 13233;
    //p2.category = "Cloths";
    //p2.stock = 5000;
    //p2.Display();
    //Console.WriteLine("is 600 stock avilable : "+p1.CkeckStock(600));



    //==== for Class Customer ====
    //Customer person1 = new Customer();
    //person1.ViewInfo();
    //person1.email = "maithili.pise79@gmail.com";
    //person1.mobileNo = 9022394007;
    //person1.address = "Pune";
    //person1.ViewInfo();



    //==== for Class Invoice ====
    //Invoice obj1 = new();
    //obj1.DisplayInvoiceDetails();
    //Console.WriteLine(obj1.TotalAmount());
    //obj1.quantity = 1;
    //obj1.DisplayInvoiceDetails();
    //Console.WriteLine(obj1.TotalAmount());



    //======================================================================================================================================================================================
    //23/01/2026
    //getter and setter (update private data )


    //what is getter and setter?
    //getter is used to read or access the value of a private field
    //setter is used to modify or update the value of a private field
    //getter provides controlled read-only access to data
    //setter provides controlled write access to data
    //getter and setter help in achieving encapsulation
    //getter can include logic to format or compute values before returning
    //setter can include validation logic before assigning values
    //getter and setter are defined using get and set keywords in C# properties
    //getter and setter allow flexibility to change internal implementation without affecting external code
    //They’re part of the encapsulation principle in Object-Oriented Programming(OOP), which hides internal data and exposes controlled access.



    //==== for student class ====
    //Student s1 = new();
    ////s1.SetName = "maithili"; we cannot update like that becuse filed is private 
    //Console.WriteLine("Name is :"+s1.GetName());
    //s1.SetName("Shivtej");
    //Console.WriteLine("Name is :"+s1.GetName());


    //==== for College Class ====
    //College smm = new();
    //smm.CollegeDetails();//default
    //smm.Email ="smm45@gmail.com";//update private data(set)
    //smm.ID = 1;
    //Console.WriteLine("College id is :" + smm.ID);//(get)
    //smm.CollegeDetails();


    //==== for Watch Class ====
    //Watch obj1 = new Watch();
    //obj1.Price = 465;
    //obj1.Company = "fastrack";
    //obj1.Type = "Smart";
    //obj1.WatchDetails();


    //==== for Mobile class ====
    //Mobile m1 = new Mobile();
    //m1.Storage = 512;
    //m1.Price = 80000;
    //m1.DisplayMobileDetails();


    //====for Laptop class====
    //Laptop l1 = new Laptop();
    //l1.Brand = "Dell";
    //l1.Processor = "intel i7";
    //l1.Ram = 8;
    //l1.Storage = 512;
    //l1.DisplayInfo();


    //=====for Table class ====
    //Table t = new Table();
    //t.Display(); //here material is wooden which is we set default to property
    //t.Material = "glass";  //change property value
    //t.Display();


    //==== for Product Class ====
    //Product p = new Product();
    //p.ProductID = 3;
    //Console.WriteLine(p.ProductID);
    //p.Display();



    //==== for Customer Class ====
    //Customer c = new Customer();
    //c.CustomerID = 45;
    //c.Email = string.Empty;
    //c.MobileNo = 7840932333;
    //c.Address = "Akluj";
    //c.ViewInfo();


    //==== for Invoice Class ====
    //Invoice n1 = new Invoice();
    //n1.DisplayInvoiceDetails();
    //n1.Price = 50000;
    //n1.InvoiceNo = "INV-35674";
    //n1.DisplayInvoiceDetails();

    //    }



    //}


    //=======================================================================================================================================================================================

    public class Program
    {
        //ToString
        public static void Main(string[] args)
        {
            //27-01-202
            //Class Work

            //TO string and Constructor

            //Student s = new Student();
            //s.DisplayStudent();
            //s.Id = 1;
            //s.Name = "Shivtej";
            //s.Marks = 34;
            //s.DisplayStudent();
            //Console.WriteLine(s.IsPass);

            //To string
            //Console.WriteLine(s.ToString());

            //Parameterized Constructor
            //Student s2 = new Student(2, "Aryan", 56);
            //Console.WriteLine(s2);
            //Console.WriteLine(s2.IsPass);



            //====================================================================================================================================================================

            //27-01-2026
            //Homework
            //use constructor and 

            //==== for Person Class ====
            //Person p1 = new Person();//here we call no argument constructor
            //Console.WriteLine(p1);
            //Person p2 = new Person("Shivtej", "Pune");//here we call parametrized constructor and we only set two parameter
            //Console.WriteLine(p2);


            //==== For Room Class ====
            //Room r1 = new Room();
            //Console.WriteLine(r1);
            //Room r2 = new(3);
            //Console.WriteLine(r2);
            //Room r3 = new(12,46000,"Wakad");
            //Console.WriteLine(r3);


            //===== For Watch Class ====
            //Watch w1 = new Watch();
            //Console.WriteLine(w1);


            //==== For Book Class ====
            //Book n1 = new Book();
            //Console.WriteLine(n1);
            //n1.Price = 100;
            //Console.WriteLine(n1);
            //Book n2 = new Book("Mrutunjay", 450);
            //Console.WriteLine(n2);
            //n2.Author = "Shivaji Sawant";
            //Console.WriteLine(n2);


            //==== For Account Class ====
            //Account acc1 = new Account();
            //Console.WriteLine(acc1);
            //Account acc2 = new Account("SBI", "Aryan", 253678900094, 450000);
            //Console.WriteLine(acc2);
            //acc2.Balance = 600000;
            //Console.WriteLine(acc2);
            //Account acc3 = new Account("Maithili", 50000,"BOI");
            //Console.WriteLine(acc3);


            //==== For Mobile Class ====
            //Mobile m1 = new Mobile();
            //Console.WriteLine(m1);
            //m1.Price = 20000;
            //Console.WriteLine(m1);


            //==== For Laptop Class ====
            //Laptop obj1 = new Laptop();
            //Console.WriteLine(obj1);


            //====For Circle Class ====
            //Circle n1 = new Circle();
            //Console.WriteLine(n1);
            //n1.Redius = 3;
            //Console.WriteLine(n1);
            //Circle n2 = new Circle(5);
            //Console.WriteLine(n2);


            ////==== For Movie Class ====
            //Movie n1 = new Movie();
            //Console.WriteLine(n1);


            //==== For Country Class ====
            //Country n1 = new Country();
            //Console.WriteLine(n1);
            //Country n2 = new Country("Nepal", 50000000, "Kathmandu");
            //Console.WriteLine(n2);
            //n2.Population = 70000000;
            //Console.WriteLine(n2);

            //==== For Company Class ====
            //Company n1 = new Company();
            //Console.WriteLine(n1);
            //Company n2 = new Company(103, "Infosys", "Bengaluru", 330000);
            //Console.WriteLine(n2);
            //Company n3 = new Company( "Reliance Industries", "Mumbai", 200000);
            //Console.WriteLine(n3);


            //==== For Bike Class ====
            //Bike n1 = new Bike();
            //Console.WriteLine(n1);
            //Bike b2 = new Bike("Yamaha R15 V4", "Yamaha", 180000, "Black");
            //Console.WriteLine(b2);




            //==========================================================================================================================================
            ////28-01-2026
            //Class work
            //Constructor Chaining 

            //Employee emp1 = new Employee();
            //Console.WriteLine(emp1);


            //User n1 = new User(101, "Maithili", 23);






            //=======================================================================================================================================


            //31/1/2026
            //copy constructor
            //Student1 s1=new Student1(1,"maithili");
            //Console.WriteLine(s1);
            //Student1 s2=new Student1(s1);
            //Console.WriteLine(s1);




            //=========================================================================================================================
            //02/02/2003
            //Homework

            //Q1.Default Constructor

            //AdminUser user1 = new AdminUser();
            //Console.WriteLine("IsActive : " + user1.IsActive);



            //Q2. Parameterized Constructor
            //LoginSessiojn user1 = new LoginSession(101, 4);
            //Console.WriteLine(user1);


            //Q3. Constructor Overloading
            //UserProfile user1 = new UserProfile("Shivtej");
            //Console.WriteLine(user1);
            //UserProfile user2 = new UserProfile("Aryan", 22);
            //Console.WriteLine(user2);
            //UserProfile user3 = new UserProfile("Gaurang", 14, "Pune");
            //Console.WriteLine(user3);


            ////Q4.Constructor Chaining using this
            //UserProfile user3 = new UserProfile("Gaurang", 14, "Pune");
            //Console.WriteLine(user3);


            //PART 3: INHERITANCE & base KEYWORD

            //Q5.Constructor Chaining using base


            //PART 4: ADVANCED CONSTRUCTORS


            //Q6.Private Constructor
            //AdminConfig obj = AdminConfig.CreateObject();
            //Console.WriteLine(obj.AppName);

            //Car c1 = Car.CreateObject("Aura", 1200000);
            //Console.WriteLine("Car Name :" + c1.Name + "  car Price :" + c1.Price);


            //Q7.Constructor vs Static Constructor
            //AppSetting app1 = new AppSetting();
            //app1.Environment = "dynamic";
            //AppSetting.ApplicationName = "facebook";//static field cannot access by using onject it can be access by using class name
            //Console.WriteLine(app1);


            //Q8.Singleton Pattern using Constructor




            //=========================================================================================================================================================

            //02/02/2003
            //Class work 

            //what is static 
            //static keyword is used to declare static members
            //static members belong to the class itself rather than to any specific instance
            //static members are shared across all instances of the class
            //purpose of static members is to provide functionality or data that is common to all instances of the class

            //static variable 

            //sparrow 
            //Sparrow s1 = new Sparrow();
            //Console.WriteLine(s1);
            //Sparrow s2 = new Sparrow();
            //Console.WriteLine(s2);
            //Sparrow s3 = new Sparrow();
            //Console.WriteLine(s3);
            //Console.WriteLine(s1);


            //sparrow1
            //Sparrow1 s1 = new Sparrow1();
            //Console.WriteLine(s1);
            //Sparrow1 s2 = new Sparrow1();
            //Console.WriteLine(s2);
            //Sparrow1 s3 = new Sparrow1();
            //Console.WriteLine(s3);
            //Console.WriteLine(s1);
            //Console.WriteLine(s1);

            //sparrow2
            //Sparrow2 s1 = new Sparrow2();
            //Console.WriteLine(s1);
            //Sparrow2 s2 = new Sparrow2();
            //Console.WriteLine(s2);
            //Sparrow2 s3 = new Sparrow2();
            //Console.WriteLine(s3);
            //Console.WriteLine(s1);
            //Console.WriteLine(s1);

            //sparrow3
            //static constructor
            //Sparrow3 s1=new Sparrow3();
            //Console.WriteLine(s1);
            //Sparrow3 s2 = new Sparrow3();
            //Console.WriteLine(s2);
            //Sparrow3 sparrow3 = new Sparrow3();
            //Console.WriteLine(sparrow3);


            //sparrow3
            //static constructor
            //Sparrow4 s1=new Sparrow4();
            //Console.WriteLine(s1);
            //Sparrow4 s2 = new Sparrow4();
            //Console.WriteLine(s2);
            //Sparrow4 sparrow3 = new Sparrow4();
            //Console.WriteLine(sparrow3);
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);



            //Example 
            //Example e1 = new Example();
            //Example e2 = new Example();
            //Console.WriteLine(e1);
            //Console.WriteLine(e2);




            //====================================================================================================================
            //04/02/2026
            //Static Method vs Instance Method 


            //Exercise 1: Identify Static vs Instance
            //Calculator.Add(12, 32);
            //Calculator.Mult(30, 10);


            ///Exercise 2: Convert Static to Instance
            //User1.Name = "Maithili";
            //Console.WriteLine(User1.Greeting());


            //Exercise 3: Utility vs Behavior
            //EmailServices email1 = new EmailServices();
            //string email = "maithili.pise2003@gmail.com";
            //string subject = "Meeting Confirmation";
            //string body = "I hope this message finds you well. I am writing to confirm our meeting scheduled for tomorrow at 10:00 AM. Please let me know if the time still works for you.";
            //email1.SendEmail(email, subject, body);


            //Exercise 4: Static Variable Counter
            //CountObj obj1 = new CountObj();
            //CountObj obj2 = new CountObj();
            //CountObj obj3 = new CountObj();
            //Console.WriteLine("Count is :"+CountObj.count);



            //Exercise 5: Fix the Compilation Error
            //Solution s1 = new Solution();
            //Solution1 s2 = new Solution1();




            //==============================================================================================================================================================================================
            //05/02/2026
            //Inheritance 
            //practice  questions 


            ////Question 1
            //Student6 s1 = new Student6();
            //Console.WriteLine($" Name :{s1.Name1} ,Age : {s1.Age1} ,RollNo :{s1.RollNo1}");


            ////Question 2
            //Car1 c1 = new Car1();
            //c1.Horn();
            //c1.Drive();


            //Question 3
            //Manager.ManageTeam();
            //Manager.Work();



            //Question 4
            //Rectangle r1 = new Rectangle();
            //Console.WriteLine(r1.Area(2, 3)); //rectangle method runs

            //Shape r2 = new Rectangle();//upcasting 
            //Console.WriteLine(r2.Area(2, 4));// shape class method run

            //when method is override
            //Rectangle r1 = new Rectangle();
            //Console.WriteLine(r1.Area(2, 3)); //rectangle method runs

            //Shape r2 = new Rectangle();//upcasting 
            //Console.WriteLine(r2.Area(2, 4));// rectangle class method run



            //Question 5 
            //1)
            //Cat c = new Cat();
            //c.Sound();   //Cat class method run
            //2)
            //Dog d=new Dog();
            //d.Sound();   //Dog class method run
            //3)
            //Animal a=new Animal();
            //a.Sound();   //Animal class method run
            //4)
            //Animal a = new Cat();
            //a.Sound();    //Cat class method because we use virtual for parent class method and override the method
            //5)
            //Animal a = new Dog();
            //a.Sound();    //Dog class 


            //==============================================================================================================================================================
            //06/02/2026

            //1)--------------
            //C c=new C();
            //c.M1();   //here C does't have any method but they inherit by the parent class


            //2)----------------
            //Reff Parent class object creation Child Class 
            //its also known as Upcasting (Vasudev Krishna)
            //P obj1 = new C();
            //obj1.M1();   //parent class  method call here(even both class have same name method)



            //3)---------------
            //P obj = new C(); //upcast
            //obj.M1();       //here call child class method because we use virtual and override the method


            //4)----------------
            //P obj = new C();
            ////obj.M1(); here get compile time error because reff type is P and P does't have any method
            //C obj = new C();


            //5)-------------------

            //P obj = new C();
            // obj.M2();  //here get Compile Time Error because the 
            //reference type is P and P does not have M2 method.

            //obj.M1(); //it gives M1 method

            //C c = new C();
            //c.M1();
            //c.M2();
            //here we are able to call M1 method because
            //the reference type is C and C has M1 method and M2 method



            //==================================================================================================================
            //Constructor Chaining in Inheritance


            //1)
            //Bird b = new Bird(); //by using this we only call Bird class method
            //2)
            //Bird sparrow = new Sparrow();
            //here call constructor od Bird and then Sparrow
            //3)
            //Bird s = new SparrowChild();
            //here first bird class constructor then Sparrow then SparrowChild Constructor
            //here we are creating an object of SparrowChild class and assigning it to a variable of type Bird. This is called upcasting.
            //The constructor of the SparrowChild class will be called, which will call the constructor of the Sparrow class, which will call the constructor of the Bird class. The output
            //output will be: SparrowChild constructor called Sparrow constructor called Bird constructor called Object Constructor
            //that means => bird ,sparrow,SparrowChild



            //-----------------------------------------------------------------------------

            //Bird b = new Bird();

            //Bird b = new SparrowChild();
            //Bird b2 = new Sparrow(); //here error is occur because Sparrow does not have default parameter
            //Bird b1 = new Sparrow(5); 
            //Bird b1 =new SparrowChild(6);//here get error because sparrowChild does not have parameterized constructor 



            //===================================================================================================================================================================================================================================================
            //07/02/2026
            //Homework


            //1)

            //Cylinder c = new Cylinder();
            //Console.WriteLine(c.ToString());
            //Console.WriteLine(c.GetArea());
            //Console.WriteLine(c.GetVolume());

            //Cylinder c=new Cylinder(3,2,"White");
            //Console.WriteLine(c);
            //Console.WriteLine(c.GetArea());
            //Console.WriteLine(c.GetVolume());

            //Cylinder c = new Cylinder(3, 2);
            //Console.WriteLine(c);
            //Console.WriteLine(c.GetArea());
            //Console.WriteLine(c.GetVolume());


            //2)-----------------------------------------

            ////Person p = new Person();//get error person does not have default constructor
            //Person p = new Person("Maithili", "Pune");
            //Console.WriteLine(p);
            ////Student1 s = new Student1();//does not have defefault constructor
            //Student1 s = new Student1("Maithili", "Pune", "BE", 2025, 78000);
            //Console.WriteLine(s);

            //Staff s1 = new Staff("Maithili", "Pune", "SMP", 50000);
            //Console.WriteLine(s1);



            //3)----------------------------------------------
            //--when we call default constructor-------

            //Point3D obj = new Point3D();
            //Console.WriteLine(obj);
            //float[] XYZ=obj.getXYZ();
            //foreach (var n in XYZ)
            //{
            //    Console.WriteLine(n);
            //}


            //-- When we update value by using method -----
            //Console.WriteLine(obj);
            //obj.XYZ(3, 3, 3);
            //Console.WriteLine(obj);
            //float[] XYZ = obj.getXYZ();
            //foreach (var n in XYZ)
            //{
            //    Console.WriteLine(n);
            //}


            //Point3D obj = new Point3D(6,6,6);
            //Console.WriteLine(obj);
            //float[] XYZ = obj.getXYZ();
            //foreach (var n in XYZ)
            //{
            //    Console.WriteLine(n);
            //}


            //Console.WriteLine(obj);
            //obj.XYZ(3, 3, 3);
            //Console.WriteLine(obj);
            //float[] XYZ = obj.getXYZ();
            //foreach (var n in XYZ)
            //{
            //    Console.WriteLine(n);
            //}



            ///* //use property for set and get array 
            ///
            // Point3D obj = new Point3D(0, 0, 0);
            // Console.WriteLine(obj);
            // //Set values for array 
            // obj.XYZ = new float[] { 2, 3, 5 };
            // //get array
            // float[] XYZ = obj.XYZ;
            // //print array
            // foreach (var n in XYZ)
            // {
            //     Console.WriteLine(n);
            // }*/





            //=====================================================================================================================================================
            //09/02/2026
            //Classwork

            //DemoModel model = new DemoModel()
            //{
            //    Nums = new int[] { 5, 2, 9, 1, 3 }
            //};
            //////here we are using constructor injection to inject the model object into the service class
            ////DemoService service = new DemoService();
            ////service.Display();


            //DemoService service = new DemoService(model);
            //service.Display();
           
            //int maxNumber = service.GetMaxNumber();
            //Console.WriteLine($"Maximum number: {maxNumber}");

            //Console.WriteLine("Sorted array:");
            //service.SortArray();





            //=====================================================================================================================================================
            //09/02/2026
            //Homework


            //1)--------------------------
            //Author author1 = new Author("Gaur Gopal Das", "gaurgopal@gmail.com", 'M');
            //Console.WriteLine(author1);
            //Book book1 = new Book("Life Amezing Secrets", author1, 250, 5);
            //Console.WriteLine(book1);



            //2)------------------------------------


            //Customer customer1 = new Customer(1, "Pooja", 'F');
            //Console.WriteLine(customer1);
            //Account acc1 = new Account(1, customer1, 250000);
            //Console.WriteLine(acc1);
            //Console.WriteLine("Balance After Withdraw : " + acc1.Withdraw(20000));
            //Console.WriteLine("Balance After Deposite : " + acc1.Deposite(50000));
            //Console.WriteLine(acc1);


            //Customer customer2 = new Customer(2, "Gayatri", 'F');
            //Console.WriteLine(customer2);
            //Account acc2 = new Account(1, customer2);
            //Console.WriteLine(acc2);
            //Console.WriteLine("Balance After Deposite : " + acc2.Deposite(20000));
            //Console.WriteLine("Balance After Withdraw : " + acc2.Withdraw(10000));



            //3)---------------------------------------


            //Customer1 n1 = new Customer1(1, "Shivtej", 20);
            //Console.WriteLine(n1);
            //Invoice invoice1 = new Invoice(1, n1, 10000);
            //Console.WriteLine("Amount After Discount = "+invoice1.AmountAfterDiscount());




            //==========================================================================================================================================================

            //HAS-A Relationship Layered Architecture Example

            //TransactionRepository repo = new TransactionRepository();
            //TransactionService services = new TransactionService(repo);
            //TransactionController controller = new TransactionController(services);
            //controller.Run();


            //-----------------------------------------
            //2)Assignment 1: Library Book System

            //LibraryRepository repository = new LibraryRepository();
            //LibraryServices services = new LibraryServices(repository);
            //LibraryController libraryController = new LibraryController(services);
            //libraryController.Run();



            //-----------------------------------------
            //3)Assignment 2: Employee Salary System

            //EmployeeRepository repository = new EmployeeRepository();
            //EmployeeService service = new EmployeeService(repository);
            //EmployeeController employeeController = new EmployeeController(service);
            //employeeController.Run();


            //=============================================================================================================================================================


            //1)Exercise 1 — Person HAS-A Address--------------------

            //Address address = new Address();
            //address.GetFullAddress("FC Road", "Pune", "413118");
            //Console.WriteLine(address);
            //Persons p = new Persons();
            //p.DisplayProfile("Maithili", 23, address);
            //Console.WriteLine(p);



            //2))Exercise 2 — Car HAS-A Engine------------------------
            //Engine engine = new Engine(2500, "Hybrid (petrol and electric) ");
            //Console.WriteLine(engine);

            //Car2 car = new Car2("Toyota", "RAV4", engine);
            //Console.WriteLine(car);
            //car.Drive();
            //car.StopCar();


            //==============================================================================================================================================================
            //Polymorphism
            //11/02/2026

            //1)Compile-Time Polymorphism
            //2)Run-Time Polymorphism

            //Homework

            //Basic Level----------------------------------------------



            //1)Create a class Calculator and overload a method Multiply(): (Two integers, Three integers)
            //Console.WriteLine("3 X 5 :"+Calculator1.Multiply(3, 5));
            //Console.WriteLine("3 X 5 X 6:"+Calculator1.Multiply(3, 5,6));
            //Console.WriteLine("3 X 5 X 9:"+Calculator1.Multiply(3, 5,9));


            //2) Create a method Display() that accepts: (int, string)
            //Show.Display(2, "Pooja");
            //Show.Display();


            //3)Overload a method Area() to calculate: (Area of square, Area of rectangle)
            //Shapes.Area(4);
            //Shapes.Area(2, 4);


            //4)Create a method PrintDetails() that takes: (name, name and age)
            //UserDetails.PrintDetails("Maithili", "Pise", 23);
            //UserDetails.PrintDetails("Pooja", 23,"Tekale");
            //UserDetails.PrintDetails("Maithili", "Pise", 23);



            //5)Is method overloading possible by changing only return type ? Explain with code.
            //Ans. NO
            //because even return type of method id different but still signature of the method is same;
            //signature (name,parameters)does not include return type 
            //That why method overloading is not possible id signature is same even return type is different



            //• INTERMEDIATE LEVEL-----------------------------------------------



            //6) Create a class Student and overload a method GetResult() : (Accept total marks, Accept marks of 3 subjects separately)
            //Console.WriteLine(StudentInfo.GetResult(100));
            //Console.WriteLine(StudentInfo.GetResult(67,89,76));



            //7)Overload a method Add() for: (int, double, decimal)
            //Console.WriteLine(Addition.Add(34, 54.4, 356));
            //Console.WriteLine(Addition.Add(54.9874,56.80m, 356));
            //Console.WriteLine(Addition.Add(34.87m,58, 356));
            //Console.WriteLine(Addition.Add(34, 54.4, 356.876m));



            //8)Create overloaded methods where parameter order is different but types are same.
            //DifferentOrder.M1(1, "Pooja", 90000);
            //DifferentOrder.M1("Maithili",4, 90000.0);
            //DifferentOrder.M1(2s, 90000.0,"Gayatri");


            //9)Create a method SendMessage() that works for: (Mobile number, Email, Mobile number with country code)
            //Console.WriteLine(Message.SendMessage("pise@gmail.com", 78409323333,91));


            //10)What will happen if two overloaded methods match due to implicit type conversion?
            //error is occurs



            //ADVANCED LEVEL----------------------------------------------------




            //11)Create a Payment class with overloaded Pay() methods for: (Cash, Card, UPI
            //Payment obj = new Payment(40000, 43256465, "MP12300000");
            //obj.Pay(8000);
            //obj.Pay(8000, "MP12300000");

        }


    }

}


