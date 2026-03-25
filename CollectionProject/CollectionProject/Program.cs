
using CollectionProject;
using CollectionProject.Entity;
using CollectionProject.Helper;
using CollectionProject.Helper.AccountHelper;
using CollectionProject.Helper.BikeHelper;
using CollectionProject.Helper.BookHelper;
using CollectionProject.Helper.CompanyHelper;
using CollectionProject.Helper.CountryHelper;
using CollectionProject.Helper.DepartmentHelper;
using CollectionProject.Helper.LaptopHelper;
using CollectionProject.Helper.MobileHelper;
using CollectionProject.Helper.MovieHelper;
using CollectionProject.Helper.PersonHelper;
using CollectionProject.Helper.RoomHelper;
using CollectionProject.Helper.StudentsHelper;
using CollectionProject.Helper.WatchHelper;
using CollectionProject.Indexer;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
public class Program
{
    public static void Main(String[] args)
    {

        //List <Employee> empList = new List <Employee> ();

        //Employee emp1=new Employee ("Pooja","Backend Developer",1);
        //Employee emp2=new Employee ("Maithili","Backend Developer",2);
        //Employee emp3=new Employee ("Gayatri","Backend Developer",3);
        //Employee emp4=new Employee ("Maithili","Backend Developer",4);
        //Employee emp5=new Employee ("Rutuja","Backend Developer",5);
        //Employee emp6=new Employee ("Snehal","Backend Developer",6);
        //Employee emp7=new Employee ("Sakshi","Backend Developer",7);

        //empList.Add (emp1);
        //empList.Add (emp2);
        //empList.Add (emp3);
        //empList.Add (emp4);
        //empList.Add(null);
        //empList.Add(null);
        //empList.Add(null);
        //empList.Add (emp5);
        //empList.Add (emp6);
        //empList.Add(emp7);
        //empList.Add(emp7);
        //empList.Add(emp1);

        //foreach (Employee emp in empList)
        //{
        //    Console.WriteLine (emp);
        //}
        //Console.WriteLine("-----------------------------");

        //empList.ForEach(e => Console.WriteLine(e));

        //Console.WriteLine("-----------------------------");

        //empList.RemoveAll(n => n == null);
        //empList.ForEach(e => Console.WriteLine(e));


        //foreach (Employee emp in empList)
        //{
        //    if(emp==null)
        //    {
        //       empList.Remove (emp);
        //    }
        //}
        //empList.ForEach(e => Console.WriteLine(e));





        //==========================================================================================================================




        //ISet<Employee> empSet = new HashSet<Employee>();
        //empSet.Add(new Employee("Pooja", "Backend Developer", 1));
        //empSet.Add(new Employee("Pooja", "Backend Developer", 1));
        //empSet.Add(new Employee("Pooja", "Backend Developer", 1));
        //empSet.Add(new Employee("Pooja", "Backend Developer", 1));
        //empSet.Add(new Employee("Pooja", "Backend Developer", 1));
        //Employee emp2 = new Employee("Maithili", "Backend Developer", 2);
        //empSet.Add(emp2);
        //empSet.Add(null);
        //empSet.Add(null);
        //empSet.Add(null);
        //empSet.Add(null);
        //empSet.Add(null);
        //empSet.Add(new Employee("gitu", "Backend Developer", 4));
        //empSet.Add(new Employee("Gayatri", "Backend Developer", 3));
        //empSet.Add(new Employee("Snehal", "Backend Developer", 5));
        //empSet.Add(new Employee("Snehal", "Backend Developer", 5));
        //empSet.Add(new Employee("Rutuja", "Backend Developer", 6));
        //empSet.Add(new Employee("Gayatri", "Backend Developer", 7));
        //empSet.Add(null);



        //foreach (Employee emp in empSet)
        //{
        //    Console.WriteLine(emp);
        //}



        //===========================================================================================================================

        //ISet<int > numberList= new SortedSet<int>();
        //numberList.Add(3);
        //numberList.Add(11);
        //numberList.Add(9);
        //numberList.Add(9);
        //numberList.Add(8);
        //numberList.Add(6);
        //numberList.Add(2);
        //numberList.Add(1);


        //foreach(var n in numberList)
        //{
        //    Console.WriteLine(n);
        //}


        //===========================================================================================================================

        //IDictionary <int ,Employee> emp=new Dictionary<int, Employee>();
        // Employee emp1 = new Employee("Pooja", "Backend Developer", 1);
        // Employee emp2 = new Employee("Maithili", "Backend Developer", 2);
        // Employee emp3 = new Employee("Gayatri", "Backend Developer", 3);
        // Employee emp4 = new Employee("Maithili", "Backend Developer", 4);
        // Employee emp5 = new Employee("Rutuja", "Backend Developer", 5);
        // Employee emp6 = new Employee("Snehal", "Backend Developer", 6);
        // Employee emp7 = new Employee("Sakshi", "Backend Developer", 7);


        // emp.Add(1, emp1);
        // emp.Add (2, emp2);
        // emp.Add (3, emp3);
        // emp.Add (4, emp4);
        // emp.Add(5, emp5);
        // emp.Add(6, emp6);
        // emp.Add(7, emp7);

        // foreach(var n in emp)
        // {
        //     Console.WriteLine(n);
        // }


        //=================================================================================================================


        //    SortedDictionary<int, Employee> emp = new SortedDictionary<int, Employee>();
        //    Employee emp1 = new Employee("Pooja", "Backend Developer", 1);
        //    Employee emp2 = new Employee("Maithili", "Backend Developer", 2);
        //    Employee emp3 = new Employee("Gayatri", "Backend Developer", 3);
        //    Employee emp4 = new Employee("Maithili", "Backend Developer", 4);
        //    Employee emp5 = new Employee("Rutuja", "Backend Developer", 5);
        //    Employee emp6 = new Employee("Snehal", "Backend Developer", 6);
        //    Employee emp7 = new Employee("Sakshi", "Backend Developer", 7);



        //    emp.Add(4, emp4);
        //    emp.Add(5, emp5);
        //    emp.Add(6, emp6);
        //    emp.Add(7, emp7);
        //    emp.Add(1, emp1);
        //    emp.Add(2, emp2);
        //    emp.Add(3, emp3);

        //    foreach (var n in emp)
        //    {
        //        Console.WriteLine(n);
        //    }

        //    var keys=emp.Keys;
        //    foreach (var key in keys)
        //    {
        //        Employee e=emp[key];
        //        Console.WriteLine(e);

        //    }



        //========================================================================================================================
        //========================================================================================================================
        //Homework
        //22/03/2025


        //C# Generic Collections Exercises

        //List Exercises 


        //1.Create a List, add 5 numbers, print all numbers, and calculate their sum.
        //List<int> numbers = new List<int>();
        //Console.WriteLine("How many number to you want to add :");
        //int num=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Numbers :");
        //for(int i=0;i<num;i++)
        //{
        //    int n=Convert.ToInt32(Console.ReadLine());
        //    numbers.Add(n);
        //}
        //numbers.ForEach(m => Console.Write(m + " "));  //if i do upcasting means if i use IList then ness to convert ToList
        //Console.Write("\nSum of all Numbers is :" + numbers.Sum());





        //2.Create a List with numbers from 1 to 20 and print only even numbers. 
        //IList<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //numbers.Where(n => n % 2 == 0).ToList().ForEach(n => Console.Write(n + ", "));





        //3.Create a List with 5 student names. Take a name from the user and check if it exists. 
        //IList<String> names = new List<String>();
        //Console.WriteLine("How many Student Names Do You want to insert :");
        //int num=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Student Name :");
        //for(int i=0;i<num;i++)
        //{
        //    names.Add(Console.ReadLine());
        //}
        //Console.WriteLine("Enter Name to check exits or not :");
        //string name=Console.ReadLine();
        //Console.WriteLine(names.Contains(name)?$"{name} is Exits":$"{name} Not Exits");




        //4.Create a Product class(Id, Name, Price). Store 5 products in a List and display products with price greater than 1000.
        //IList<Product> productList = new List<Product>();
        //Console.WriteLine("How Many Product Do you want to add :");
        //int num=Convert.ToInt32(Console.ReadLine());
        //for(int i=0;i<num;i++)
        //{
        //    Console.WriteLine("Enter Product ID :");
        //    int id=Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Product Name :");
        //    string name=Console.ReadLine();
        //    Console.WriteLine("Enter Pproduct Price :");
        //    double price=Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("\n\n");
        //    productList.Add(new Product(id, name, price));
        //}
        //Console.WriteLine("Product which price is greater than 1000:");
        //productList.Where(n=>n.Price>1000).ToList().ForEach(n => Console.WriteLine(n));



        //=====================================


        //Dictionary<TKey, TValue> Exercises
        //5. Create a Dictionary<int, string> to store student Id and Name.Add 5 entries and print them. 
        //IDictionary <int,string> student= new Dictionary <int,string> ();
        //int id = 1;
        //for(int i=0;i<5;i++)
        //{
        //    Console.WriteLine("Enter Student Name :");
        //    string name=Console.ReadLine();
        //    student.Add (id, name);
        //    id++;
        //}
        //foreach(var n in student)
        //{
        //    Console.WriteLine($"{n.Key} : {n.Value}");
        //}


        ////6. Ask the user for a student ID and display the corresponding name using a Dictionary.
        //Console.WriteLine("Enter the Student ID to Display Corresponding name :");
        //int num=Convert.ToInt32 (Console.ReadLine());
        //if (student.ContainsKey(num))
        //{
        //    Console.WriteLine($"{num} :{student[num]}");
        //}
        //else { Console.WriteLine("ID not exits"); }



        //7.Given a string “hello world hello”, count the frequency of each word using a Dictionary. 
        //String str = "hello world hello";
        //IDictionary <string,int> nameFrequency= new Dictionary <string,int> ();
        //foreach(var n in str.Split (" "))
        //{

        //}



        //8.Create a Dictionary<string, double> for product names and prices. Search for a product and display its price.
        //IDictionary <string ,double> productList = new Dictionary<string ,double>();
        //Console.WriteLine("How Many Product Do you want to add :");
        //int num = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < num; i++)
        //{

        //    Console.WriteLine("Enter Product Name :");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter Pproduct Price :");
        //    double price = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("\n\n");
        //    var obj=new Product(name, price);
        //    productList.Add( obj.Name,obj.Price);
        //}
        //Console.WriteLine("Search the Product :");
        //string nameP= Console.ReadLine();
        //if(productList.ContainsKey(nameP))
        //{
        //    Console.WriteLine("Price :"+productList[nameP]);
        //}
        //else
        //{
        //    Console.WriteLine("Product not avilable");
        //}





        //======================================


        //HashSet Exercises 

        //9. Take 10 numbers as input and store them in aHashSet. Print only unique values.
        //HashSet<int> numbers= new HashSet<int>();
        //Console.WriteLine("Enter 10 numbers :");
        //for(int i=0;i<10;i++)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    numbers.Add(n);
        //}
        //Console.WriteLine("\n\n Numbers :");
        //foreach(int n in numbers)
        //{
        //    Console.WriteLine(n);
        //}



        //10. Remove duplicates from a list of integers using HashSet.
        //List<int> numbers= new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 5, 2, 2, 2 };
        //HashSet<int> num = new HashSet<int>(numbers);
        //foreach (int n in num)
        //{
        //    Console.WriteLine(n);
        //}



        //11.Given two lists of integers, find the common elements using HashSet.
        //List<int> num1= new List<int>() { 1, 2, 3, 4, 5,6 };
        //List<int> num2= new List<int>() { 1, 2, 3,};
        //var common=num1.Intersect(num2);
        //foreach (int n in common)
        //{
        //    Console.WriteLine(n);
        //}



        //=======================================


        //Combined Exercises 
        //12. Create a Student class. Store students in a List, use a Dictionary<int, Student> for lookup, and ensure no duplicate IDs using HashSet. 



        //13.Create a shopping cart using List and Dictionary<string, int> for quantity.Calculate total bill.


        //======================================================================================================================
        //======================================================================================================================


        //Advanced Exercises 
        //14.Group a list of strings by their first character using Dictionary<char, List>.
        //15.Count frequency of numbers in a listand display them sorted by highest frequency.








        //========================================================================================================================================================
        //========================================================================================================================================================
        //========================================
        //23/03/2025
        //Class Work



        //----------------- Comparable ---------------------------
        //Employee emp=new Employee("maithili","sd",1);
        //Employee emp1=new Employee("gitu","sd",2);

        //IList<Employee> empList = new List<Employee>();
        //empList.Add(emp);
        //empList.Add(emp1);
        //Console.WriteLine("How many records do you want to add :");
        //int num=Convert.ToInt32(Console.ReadLine());
        //for(int i=0;i<num;i++)
        //{
        //    Console.WriteLine("Enter the Name :");
        //    string name=Console.ReadLine();
        //    Console.WriteLine("Enter Position :");
        //    string position =Console.ReadLine();
        //    Console.WriteLine("Enter emp id :");
        //    int id=Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("\n\n");
        //    empList.Add(new Employee(name,position,id));
        //}
        //empList.OrderBy(n=>n.EmployeeID).ToList().ForEach(n=> Console.WriteLine(n));

        ////empList.Sort();
        ///empList.Reverse();
        //    int a = 3;



        //--------------Comparer-----------------------



        //DepartmentIdWiseSort idWise= new DepartmentIdWiseSort();
        //NameWiseSort nameWise= new NameWiseSort();

        //ISet<Student> studentList = new SortedSet<Student>(nameWise);
        //studentList.Add(new Student(1, "Maithili", 87));
        //studentList.Add(new Student(2, "gitu", 89));
        //studentList.Add(new Student(4, "Pooja", 90));
        //studentList.Add(new Student(3, "gayatri", 93));

        //foreach(Student student in studentList)
        //{
        //    Console.WriteLine(student);
        //}





        //=========================================================================================================================================================
        //=========================================================================================================================================================
        //23/03/2026
        //Homework



        //1)--------Account-----------

        //AccountNoWiseSort accountWise=new AccountNoWiseSort();
        //BalanceWiseSort balanceWise=new BalanceWiseSort();

        //ISet<Account> accountList1 = new SortedSet<Account>(balanceWise);
        //accountList1.Add(new Account(10011002,"BOI","Gayatri",1));
        //accountList1.Add(new Account(10011003,"SBI","Maithili",500000));
        //accountList1.Add(new Account(10011005,"BOI","Rutuja",156000));
        //accountList1.Add(new Account(10011009,"HDFC","Pooja",400000));
        //accountList1.Add(new Account(10011004,"SBI","Aditya",100000));
        //accountList1.Add(new Account(10011007,"BOI","Onkar",200000));

        //Console.WriteLine("Balance Wise Sorting :");
        //foreach(var n in  accountList1)
        //{
        //    Console.WriteLine(n);
        //}


        //ISet<Account> accountList2 = new SortedSet<Account>(accountWise);
        //accountList2.Add(new Account(10011002,"BOI","Gayatri",1));
        //accountList2.Add(new Account(10011003,"SBI","Maithili",500000));
        //accountList2.Add(new Account(10011005,"BOI","Rutuja",156000));
        //accountList2.Add(new Account(10011009,"HDFC","Pooja",400000));
        //accountList2.Add(new Account(10011004,"SBI","Aditya",100000));
        //accountList2.Add(new Account(10011007,"BOI","Onkar",200000));

        //Console.WriteLine("Account Number  Wise Sorting :");
        //foreach(var n in  accountList2)
        //{
        //    Console.WriteLine(n);
        //}




        //2)-------------Bike-------------------
        //BikePriceWiseSort priceWiseSort = new BikePriceWiseSort();
        //BikeIdWiseSort bikeIdWiseSort = new BikeIdWiseSort();
        //Bike b1=new Bike(101, "Royal Enfield Bullet 350",162000);
        //Bike b2=new Bike(105, "Yamaha R15 V4", 166000);
        //Bike b3=new Bike(106, "Kawasaki Ninja 300Kawasaki Ninja 300", 362000);
        //Bike b4=new Bike(102, "KTM RC 200", 215000);
        //Bike b5=new Bike(103, "Suzuki Gixxer SF 250", 362000);

        //ISet<Bike> bikes = new SortedSet<Bike>(priceWiseSort);
        //bikes.Add(b1);
        //bikes.Add(b2);
        //bikes.Add(b3);
        //bikes.Add(b4);
        //bikes.Add(b5);
        //Console.WriteLine("Price wise Sorted :");  
        //foreach(Bike b in bikes)
        //{
        //    Console.WriteLine(b);
        //}
        //ISet<Bike> bikeList = new SortedSet<Bike>(bikeIdWiseSort);
        //bikeList.Add(b1);
        //bikeList.Add(b2);
        //bikeList.Add(b3);
        //bikeList.Add(b4);
        //bikeList.Add(b5);
        //Console.WriteLine("Bike Id wise Sorted :");
        //foreach (Bike b in bikeList)
        //{
        //    Console.WriteLine(b);
        //}





        //3)---------------Book--------------
        //BookPriceWiseSort priceWiseSort = new BookPriceWiseSort();
        //BookIdWiseSort bookIdWiseSort = new BookIdWiseSort();

        //Book b1= new Book(101,"C Sharp Fundamentals",700);
        //Book b2= new Book(108,"Java Fundamentals",600);
        //Book b3= new Book(109,"Python",400);
        //Book b4= new Book(105,"C  Fundamentals",300);
        //Book b5= new Book(103,".Net Framework",1000);

        ////ISet<Book> bookList1 = new SortedSet<Book>(priceWiseSort);
        //ISet<Book> bookList1 = new SortedSet<Book>(bookIdWiseSort);

        //bookList1.Add(b1);
        //bookList1.Add(b2);
        //bookList1.Add(b3);
        //bookList1.Add(b4);
        //bookList1.Add(b5);

        //foreach(Book book in bookList1)
        //{
        //    Console.WriteLine(book);
        //}



        //4)------------- Company ---------------
        //Company n1 = new Company(203,"Capgemini",570000,1000000000);
        //Company n2 = new Company(201,"TCS",570000,7500000000);
        //Company n3 = new Company(102,"Cognizant",570000,5200000000);
        //Company n4 = new Company(200,"JPMorgan",570000,14300000000);
        //Company n5 = new Company(250,"Wipro",570000,7600000000);

        //TurnOverWiseSort turnOverWiseSort = new TurnOverWiseSort();
        //CompanyIdWiseSort companyIdWiseSort = new CompanyIdWiseSort();

        //ISet<Company> companies = new SortedSet<Company>(turnOverWiseSort);
        //companies.Add(n1);
        //companies.Add(n2);
        //companies.Add(n3);
        //companies.Add(n4);
        //companies.Add(n5);
        //Console.WriteLine("TurnOver wise Sorted");
        //foreach(Company company in companies)
        //{
        //    Console.WriteLine(company);
        //}


        //ISet<Company> companiesList = new SortedSet<Company>(companyIdWiseSort);
        //companiesList.Add(n1);
        //companiesList.Add(n2);
        //companiesList.Add(n3);
        //companiesList.Add(n4);
        //companiesList.Add(n5);
        //Console.WriteLine("\n\nCompany Id  wise Sorted");
        //foreach(Company company in companiesList)
        //{
        //    Console.WriteLine(company);
        //}





        //5)---------------Country---------------
        //Country n1= new Country("India",1250000000,91);
        //Country n2= new Country("China",1550000000,34);
        //Country n3= new Country("Russia",19250000,89);
        //Country n4= new Country("Japan",11200000,82);
        //Country n5= new Country("Germany",925000000,62);

        //PopulationWiseSort populationWise = new PopulationWiseSort();
        //CountryNameWiseSort countryNameWiseSort = new CountryNameWiseSort();    

        //ISet <Country> countries = new SortedSet<Country> (populationWise);
        //countries.Add(n1);
        //countries.Add(n2);
        //countries.Add(n3);
        //countries.Add(n4);
        //countries.Add(n5);

        //Console.WriteLine(" Population wise sorted ");
        //foreach(Country country in countries)
        //{
        //    Console.WriteLine (country);
        //}

        //ISet <Country> countrieList = new SortedSet<Country> (countryNameWiseSort);
        //countrieList.Add(n1);
        //countrieList.Add(n2);
        //countrieList.Add(n3);
        //countrieList.Add(n4);
        //countrieList.Add(n5);

        //Console.WriteLine("\n\nName wise sorted ");
        //foreach(Country country in countries)
        //{
        //    Console.WriteLine (country);
        //}




        //--------------Laptop-------------
        //LaptopPriceWiseSort laptopPriceWiseSort = new LaptopPriceWiseSort();
        //LaptopIdWiseSort laptopIdWiseSort = new LaptopIdWiseSort();

        //ISet<Laptop> laptops = new SortedSet<Laptop>(laptopPriceWiseSort);
        //laptops.Add(new Laptop(101, "Victus", 75000, 512));
        //laptops.Add(new Laptop(101, "HP intel Core i5", 65000, 512));
        //laptops.Add(new Laptop(101, "HP intel Core i3", 55000, 512));
        //laptops.Add(new Laptop(101, "Dell ", 78000, 512));
        //Console.WriteLine("Price Wise Sorted :");
        //foreach(Laptop l in laptops)
        //{
        //    Console.WriteLine(l);
        //}
        //ISet<Laptop> laptopList= new SortedSet<Laptop>(laptopIdWiseSort);
        //laptopList.Add(new Laptop(101, "Victus", 75000, 512));
        //laptopList.Add(new Laptop(103, "HP intel Core i5", 65000, 512));
        //laptopList.Add(new Laptop(104, "HP intel Core i3", 55000, 512));
        //laptopList.Add(new Laptop(102, "Dell ", 78000, 512));
        //Console.WriteLine("\n\nLaptop Id Wise Sorted :");
        //foreach(Laptop l in laptopList)
        //{
        //    Console.WriteLine(l);
        //}




        //------------Mobile----------------
        //MobilePriceWiseSort mobilePriceWiseSort = new MobilePriceWiseSort();
        //MobileIdWiseSort mobileIdWiseSort = new MobileIdWiseSort();

        //ISet <Mobile> mobiles = new SortedSet<Mobile>(mobilePriceWiseSort);
        //mobiles.Add(new Mobile(102, "S26 ultra", 120000));
        //mobiles.Add(new Mobile(107, "IPhone 17Pro", 70000));
        //mobiles.Add(new Mobile(103, "S24 Ultra", 65000));
        //mobiles.Add(new Mobile(109, "IPhone 14 Pro Max", 60000));

        //Console.WriteLine("price wise Sorted :");
        //foreach (Mobile mobile in mobiles)
        //{
        //    Console.WriteLine(mobile);
        //}
        //ISet <Mobile> mobileList = new SortedSet<Mobile>(mobileIdWiseSort);
        //mobileList.Add(new Mobile(102, "S26 ultra", 120000));
        //mobileList.Add(new Mobile(107, "IPhone 17Pro", 70000));
        //mobileList.Add(new Mobile(103, "S24 Ultra", 65000));
        //mobileList.Add(new Mobile(109, "IPhone 14 Pro Max", 60000));

        //Console.WriteLine("price wise Sorted :");
        //foreach (Mobile mobile in mobileList)
        //{
        //    Console.WriteLine(mobile);
        //}




        //---------------Movie------------
        //ReleaseYearWiseSort releaseYearWiseSort = new ReleaseYearWiseSort();
        //MovieCollectionWiseSort movieCollectionWiseSort = new MovieCollectionWiseSort();

        //ISet <Movie> movieList = new SortedSet<Movie>(releaseYearWiseSort);
        //movieList.Add(new Movie(183, "Yeh jawani hai Diwani", 500000000, 2013));
        //movieList.Add(new Movie(164, "Hamari Adhuri kahani", 10000000, 2015));
        //movieList.Add(new Movie(563, "Golmal", 40000000, 2011));
        //movieList.Add(new Movie(312, "Faltu", 500000000, 2017));

        //Console.WriteLine("Sorted by relese Year");
        //foreach(Movie movie in movieList)
        //{
        //    Console.WriteLine(movie);
        //}

        //ISet<Movie> movies = new SortedSet<Movie>(movieCollectionWiseSort);
        //movies.Add(new Movie(183, "Yeh jawani hai Diwani", 500000000, 2013));
        //movies.Add(new Movie(164, "Hamari Adhuri kahani", 10000000, 2015));
        //movies.Add(new Movie(563, "Golmal", 40000000, 2011));
        //movies.Add(new Movie(312, "Faltu", 550000000, 2017));

        //Console.WriteLine("Collection by relese Year");
        //foreach (Movie movie in movies)
        //{
        //    Console.WriteLine(movie);
        //}





        //--------------Person----------------
        //CityWiseSort cityWiseSort = new CityWiseSort();
        //PersonIdWiseSort personIdWiseSort = new PersonIdWiseSort();

        //ISet<Person> people = new SortedSet<Person>(personIdWiseSort);
        //people.Add(new Person(102, "Maithili", "Akluj"));
        //people.Add(new Person(102, "Pooja", "Solapur"));
        //people.Add(new Person(102, "Rutuja", "Sangali"));
        //people.Add(new Person(102, "Gayatri", "Pune"));

        //Console.WriteLine("Sorted by ID wise");
        //foreach (Person person in people)
        //{
        //    Console.WriteLine(person);
        //}
        //ISet <Person> peopleList = new SortedSet<Person>(cityWiseSort);
        //peopleList.Add(new Person(102, "Maithili", "Akluj"));
        //peopleList.Add(new Person(102, "Pooja", "Solapur"));
        //peopleList.Add(new Person(102, "Rutuja", "Sangali"));
        //peopleList.Add(new Person(102, "Gayatri", "Pune"));

        //Console.WriteLine("Sorted by city wise");
        //foreach(Person person in peopleList)
        //{
        //    Console.WriteLine(person);
        //}



        //--------------Room------------------
        //RoomNoWiseSort roomNoWiseSort = new RoomNoWiseSort();
        //RentWiseSort rentWiseSort = new RentWiseSort();

        //ISet <Room> roomList = new SortedSet<Room>(rentWiseSort);
        //roomList.Add(new Room(4, 6000, 3));
        //roomList.Add(new Room(1, 8000, 7));
        //roomList.Add(new Room(3, 6000, 4));
        //roomList.Add(new Room(5, 7000, 6));

        //Console.WriteLine("Rent wise Sort");
        //foreach(Room room in roomList)
        //{
        //    Console.WriteLine(room);
        //}

        //ISet<Room> rooms = new SortedSet<Room>(roomNoWiseSort);
        //rooms.Add(new Room(4, 6000, 3));
        //rooms.Add(new Room(1, 8000, 7));
        //rooms.Add(new Room(3, 6000, 4));
        //rooms.Add(new Room(5, 7000, 6));

        //Console.WriteLine("Room no wise Sort");
        //foreach (Room room in rooms)
        //{
        //    Console.WriteLine(room);
        //}







        //==================================================================================================================================================================
        //======================================================================================================================================================================
        //24/03/2026
        //ClassWork



        //ISet<Person> people = new SortedSet<Person>(Comparer<Person>.Create((x, y) => x.Id.CompareTo(y.Id)));
        //people.Add(new Person(102, "Maithili", "Akluj"));
        //people.Add(new Person(102, "Pooja", "Solapur"));
        //people.Add(new Person(102, "Rutuja", "Sangali"));
        //people.Add(new Person(102, "Gayatri", "Pune"));
        //foreach (Person person in people)
        //{
        //    Console.WriteLine(person);
        //}

        //Comparer<Person> obj = Comparer<Person>.Create((x, y) => x.Id.CompareTo(y.Id));
        //ISet<Person> people = new SortedSet<Person>(obj);
        //people.Add(new Person(102, "Maithili", "Akluj"));
        //people.Add(new Person(105, "Pooja", "Solapur"));
        //people.Add(new Person(108, "Rutuja", "Sangali"));
        //people.Add(new Person(103, "Gayatri", "Pune"));
        //foreach(Person person in people)
        //{
        //    Console.WriteLine(person);
        //}



        //------------ Indexer ------------

        //CandidateList candidate=new CandidateList();
        //candidate.Add(new Candidates(101, "Maithili", "Akluj"));
        //candidate.Add(new Candidates(202, "Shivtej", "Pune"));
        //candidate.Add(new Candidates(303, "Gayatri", "Solapur"));
        //candidate.Add(new Candidates(404, "Vaishnavi", "Kolhapur"));
        //candidate.Add(new Candidates(505, "Aryan", "Mumbai"));


        //Console.WriteLine(candidate[0]);
        //Console.WriteLine(candidate[2]);

        //candidate[1] = new Candidates(2, "Sanket", "Akluj");
        //candidate[0] = new Candidates(1, "Maithili", "Pune");
        ////if here i put index 6 which is not exits before then exception is occurs 
        //Console.WriteLine(candidate[0]);


        //Without Add Function
        //CandidateList candidate = new CandidateList();
        //candidate.candidatesList.Add(new Candidates(101, "Maithili", "Akluj"));
        //candidate.candidatesList.Add(new Candidates(202, "Shivtej", "Pune"));
        //candidate.candidatesList.Add(new Candidates(303, "Gayatri", "Solapur"));
        //candidate.candidatesList.Add(new Candidates(404, "Vaishnavi", "Kolhapur"));
        //candidate.candidatesList.Add(new Candidates(505, "Aryan", "Mumbai"));

        //Console.WriteLine(candidate[0]);
        //candidate[0] = (new Candidates(101, "Maithili", "Pune"));
        //Console.WriteLine(candidate[0]);






        //=====================================================================================================================================================
        //===================================================================================================================================================
        //24/03/2026
        //HomeWork

        //👉 IComparable → default sorting
        //👉 IComparer → multiple sorting
        //👉 Lambda → quick sorting
        //👉 LINQ → clean & powerful sorting




        //A)--------------------IComparable------------------

        //1)Car
        //List <Car> carList = new List<Car> ();
        //carList.Add(new Car(1, "Seltos", 1700000));
        //carList.Add(new Car(2, "Aura", 1200000));
        //carList.Add(new Car(4, "Creta", 1250000));
        //carList.Add(new Car(3, "Fortuner", 2700000));
        //carList.Add(new Car(5, "jeep", 2000000));

        //carList.Sort();
        //carList.ForEach(car=>Console.WriteLine(car));



        //2)Teacher
        //List<Teacher> teachers = new List<Teacher>();
        //teachers.Add(new Teacher("Satish Sir","Aptitude",9));
        //teachers.Add(new Teacher("Pratham Sir",".Net",4));
        //teachers.Add(new Teacher("Ritesh Sir","Angular",5));
        //teachers.Add(new Teacher("Hrishikesh Sir","Java",3));
        //teachers.Sort();
        //teachers.ForEach(Console.WriteLine);




        //B)---------------------IComparer--------------------



        //1)Department
        /*TeacherNoWiseSort teacherNoWiseSort = new TeacherNoWiseSort();
        DepartmentIdWiseSort idWiseSort = new DepartmentIdWiseSort();

        ISet<Department> departments = new SortedSet<Department>(teacherNoWiseSort);
        departments.Add(new Department(101, "Computer", 32));
        departments.Add(new Department(104, "Civil", 20));
        departments.Add(new Department(107, "IT", 25));
        departments.Add(new Department(103, "E & TC", 27));
        departments.Add(new Department(102, "AI & DS", 10));
        Console.WriteLine("Teacher Number Wise Sorted ");
        foreach(Department department in departments)
        {
            Console.WriteLine(department);
        }

        ISet<Department> departmentList = new SortedSet<Department>(idWiseSort);
        departmentList.Add(new Department(101, "Computer", 32));
        departmentList.Add(new Department(104, "Civil", 20));
        departmentList.Add(new Department(107, "IT", 25));
        departmentList.Add(new Department(103, "E & TC", 27));
        departmentList.Add(new Department(102, "AI & DS", 10));
        Console.WriteLine("ID Wise Sorted ");
        foreach (Department department in departmentList)
        {
            Console.WriteLine(department);
        }*/




        //2) Watch
        //PriceWiseSort priceWiseSort = new PriceWiseSort();
        //WatchIdWiseSort watchIdWiseSort = new WatchIdWiseSort();
        //ISet<Watch> watches = new SortedSet<Watch>(priceWiseSort);
        //watches.Add(new Watch(1, "Smart", "Apple", 50000));
        //watches.Add(new Watch(2, "Digital", "Fastrack", 7000));
        //watches.Add(new Watch(5, "Analog", "Titen", 10000));
        //watches.Add(new Watch(4, "Smart", "Noise", 5000));
        //watches.Add(new Watch(3, "Analog", "Rolex", 150000));
        //Console.WriteLine("Price Wise Sort ");
        //foreach (Watch w in watches)
        //{
        //    Console.WriteLine(w);
        //}

        //ISet<Watch> watchList = new SortedSet<Watch>(watchIdWiseSort);
        //watchList.Add(new Watch(1, "Smart", "Apple", 50000));
        //watchList.Add(new Watch(2, "Digital", "Fastrack", 7000));
        //watchList.Add(new Watch(5, "Analog", "Titen", 10000));
        //watchList.Add(new Watch(4, "Smart", "Noise", 5000));
        //watchList.Add(new Watch(3, "Analog", "Rolex", 150000));
        //Console.WriteLine("\n\nId Wise Sort ");
        //foreach(Watch w in watchList)
        //{
        //    Console.WriteLine(w);
        //}




        //------------------- Lambda Function--------------------


        //1)City
        //ISet<City> cities = new SortedSet<City>(Comparer<City>.Create((x,y)=>x.Population.CompareTo(y.Population)));
        //cities.Add(new City("Pune", 413202, 10500000));
        //cities.Add(new City("Mumbai", 413201, 12300000));
        //cities.Add(new City("Solapur", 413113, 4800000));
        //cities.Add(new City("Kolhapur", 413210, 5000000));
        //cities.Add(new City("Akluj", 413101, 2030000));

        //Console.WriteLine("Population Wise Sort ");
        //foreach(City city in cities)
        //{
        //    Console.WriteLine(city);
        //}



        //2)Customer
        //Comparer<Customer> idWise= Comparer<Customer>.Create((x,y)=>x.Id.CompareTo(y.Id));

        //ISet<Customer> customers = new SortedSet<Customer>(idWise);
        //customers.Add(new Customer(1,"Pooja","Mohol"));
        //customers.Add(new Customer(4,"  Maithili","Akluj"));
        //customers.Add(new Customer(3,"Gayatri","Yashwantnagar"));
        //customers.Add(new Customer(2,"Rutuja","Sangali"));

        //foreach(Customer customer in customers)
        //{
        //    Console.WriteLine(customer);
        //}









        //==================================================================================================================================================
        //=================================================================================================================================================
        //23/03/2026
        //Homework (Practice Question)



        //Q1. Sort numbers in ascending order
        //Input: [5, 2, 8, 1]
        //Output: [1, 2, 5, 8]  Use: List.Sort()
        //List<int> number=new List<int>() { 5, 2, 8, 1 };
        //number.Sort();
        //number.ForEach(n=> Console.WriteLine(n));


        //----------------------------------------
        //Q2.Sort numbers in descending order
        //👉 Use: Sort() + Reverse()
        //List<int> numbers=new List<int>() { 6, 3, 2, 6, 9, 5, 1, 2 };
        //numbers.Sort();
        //numbers.Reverse();  
        //numbers.ForEach(x => Console.WriteLine(x));



        //-----------------------------------------
        //Q3. Sort string list alphabetically
        // Input: ["Banana", "Apple", "Mango"]
        //List<String> Fruits=new List<String>() { "Banana", "Apple", "Mango" };
        //Fruits.Sort();
        //Fruits.ForEach(n=> Console.WriteLine(n));   




        //-----------------------------------------
        //Q4. Sort array using Array.Sort()

        //int[] arr = { 1, 2, 3, 5, 7, 4, 3, 2, 78, 4 };
        //Array.Sort(arr);
        //foreach(int i in arr)
        //{
        //    Console.WriteLine(i);
        //}


        //------------------------------------------
        //LEVEL 2: CUSTOM OBJECT SORTING
        //-------------------------------------------


        //Q5. Sort students by Age using IComparable
        //List <Student> students = new List <Student> ();
        //students.Add (new Student (1,"Pooja",99));
        //students.Add (new Student (4,"Maithili",35));
        //students.Add (new Student (5,"Gayatri",92));
        //students.Add (new Student (3,"Neha",100));
        //students.Add (new Student (2,"Sayali",98));
        //students.Sort();
        //students.ForEach (Console.WriteLine);



        //Q6.Sort students by Name using IComparer
        //AgeWiseSort obj=new AgeWiseSort();
        //ISet<Students> students=new SortedSet<Students>(obj);
        //students.Add(new Students("Maithili", 23));
        //students.Add(new Students("Gayatri", 21));
        //students.Add(new Students("Pooja", 22));
        //students.Add(new Students("Rutuja", 24));
        //foreach (Students s in students)
        //{
        //    Console.WriteLine(s);
        //}



        //----------------------------------

        //Q7.Sort students by Age using Lambda
        //👉 list.Sort((x, y) => x.Age.CompareTo(y.Age));
        //ISet<Students> students = new SortedSet<Students>(Comparer<Students>.Create((x,y)=>x.Age.CompareTo(y.Age)));
        //students.Add(new Students("Maithili", 23));
        //students.Add(new Students("Gayatri", 21));
        //students.Add(new Students("Pooja", 22));
        //students.Add(new Students("Rutuja", 24));
        //foreach (Students s in students)
        //{
        //    Console.WriteLine(s);
        //}




        //==================================================
        //LEVEL 3: LINQ SORTING
        //==================================================



        //Q8. Sort students by Name (ascending)
        //👉 Use OrderBy()
        //IList<Students> students = new List<Students>();
        //students.Add(new Students("Maithili", 23));
        //students.Add(new Students("Gayatri", 21));
        //students.Add(new Students("Pooja", 22));
        //students.Add(new Students("Rutuja", 24));
        //students.OrderBy(x=>x.Age).ToList().ForEach(Console.WriteLine);



        //----------------------------------

        //Q9. Sort students by Age (descending)
        //👉 Use OrderByDescending()
        //IList<Students> students = new List<Students>();
        //students.Add(new Students("Maithili", 23));
        //students.Add(new Students("Gayatri", 21));
        //students.Add(new Students("Pooja", 22));
        //students.Add(new Students("Rutuja", 24));
        //students.OrderByDescending(x => x.Age).ToList().ForEach(Console.WriteLine);


        //Q10.Multi sorting
        //👉 First by Name, then by Age
        //OrderBy(x => x.Name).ThenBy(x => x.Age)
        //IList<Students> students = new List<Students>();
        //students.Add(new Students("Maithili", 23));
        //students.Add(new Students("Gayatri", 21));
        //students.Add(new Students("Pooja", 22));
        //students.Add(new Students("Rutuja", 24));
        //students.OrderByDescending(x => x.Age).ThenBy(x=>x.Name).ToList().ForEach(Console.WriteLine);









    }

}

