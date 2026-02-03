using OOPs.Models;
using System;
using System.Buffers.Text;
using System.Reflection;
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



            //---------------------------------------------------------------------------------------------------------------

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



            //31/1/2026
            //copy constructor





            //==================================================================================================================

            //01/02/2003
            //static





            //=========================================================================================================================
            //01/02/2003
            //Homework

            //Q1.Default Constructor

            //AdminUser user1 = new AdminUser();
            //Console.WriteLine("IsActive : " + user1.IsActive);



            //Q2. Parameterized Constructor
            //LoginSession user1 = new LoginSession(101, 4);
            //Console.WriteLine(user1);


            //Q3. Constructor Overloading
            //UserProfile user1 = new UserProfile("Shivtej");
            //Console.WriteLine(user1);
            //UserProfile user2 = new UserProfile("Aryan", 22);
            //Console.WriteLine(user2);
            //UserProfile user3 = new UserProfile("Gaurang", 14, "Pune");
            //Console.WriteLine(user3);


            //Q4.Constructor Chaining using this
            //UserProfile user3 = new UserProfile("Gaurang", 14, "Pune");
            //Console.WriteLine(user3);


            //PART 3: INHERITANCE & base KEYWORD

            //Q5.Constructor Chaining using base


            //PART 4: ADVANCED CONSTRUCTORS
            //Q6.Private Constructor



            //Q7.Constructor vs Static Constructor
            //AppSetting app1 = new AppSetting();
            //Console.WriteLine(app1);




        }
    }
}

