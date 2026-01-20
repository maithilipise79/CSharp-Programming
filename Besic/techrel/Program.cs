using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Besic
{

    public class program
    {
        // public struct Student
        //{
        //    public string name;
        //    public int rollno;
        //    public char div;
        //    public float percentage;
        //}

        //public struct Car
        //{
        //    public string name;
        //    public int price;
        //}
        //public static void Main(string[] args)
        //{

        //Student s1 = new Student();

        //s1.name = "maithili";
        //s1.rollno = 3;
        //s1.div = 'A';
        //s1.percentage = 67.9F;

        //Console.WriteLine($"name :{s1.name} rollno: {s1.rollno} division :{s1.div} ");

        //Car c = new Car();
        //c.name = "Seltos";
        //c.price = 1500000;

        //Console.WriteLine($" name : {c.name}  peice :{c.price} ");

        //int no;
        //double area;
        //long ph;
        //decimal payment;
        //string name;
        //float percentage;
        //char d;

        //Console.WriteLine(" Enter any int number :");
        //no = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(" Given int number :"+no);

        //Console.WriteLine(" Enter any double value to store in area variable :");
        //area = double.Parse(Console.ReadLine());
        //Console.WriteLine(" given double value to store in area variable :"+area);


        //Console.WriteLine(" Enter any long value to store in ph variable :");
        //ph = long.Parse(Console.ReadLine());
        //Console.WriteLine(" Given long value to store in ph variable :"+ph);


        //Console.WriteLine(" Enter any decimal number to store in payment variable :");
        //payment = Convert.ToDecimal(Console.ReadLine());
        //Console.WriteLine(" Given decimal number to store in payment variable :"+payment);


        //Console.WriteLine(" Enter any string as a name :");
        //name = Console.ReadLine();
        //Console.WriteLine(" Given string as a name :"+name);


        //Console.WriteLine(" Enter any float value as a percentage :");
        //percentage = float.Parse(Console.ReadLine());
        //Console.WriteLine(" Given float value as a percentage :"+percentage);

        //Console.WriteLine(" Enter any char value");
        //d = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine(" given  char value is :"+d);

        //----------------------------------------------------------------------------------------------------------



        //1.positive negative 
        //int num;
        //Console.WriteLine("\n Enter any number to check positive and negative :");
        //num = Convert.ToInt32(Console.ReadLine());
        //if(num>=0)
        //{
        //    Console.WriteLine(" Positive number ");
        //} 
        //else 
        //{
        //    Console.WriteLine("Negative number ");
        //}



        //-----------------------------------------------------------------------------------------------------


        //2.even odd
        //int num;
        //Console.WriteLine("\n Enter any number to check odd and even  :");
        //num = Convert.ToInt32(Console.ReadLine());
        //if(num%2==0)
        //{
        //    Console.WriteLine($" {num} is even number");
        //}
        //else
        //{
        //    Console.WriteLine($" {num} is odd number");
        //}




        //3.leap year check
        //int year;
        //Console.WriteLine("Enter year to check leap or not :");
        //year = Convert.ToInt32(Console.ReadLine());
        //if(year%4==0 && year%400==0)
        //{
        //    Console.WriteLine("Leap year");
        //}
        //else
        //{
        //    Console.WriteLine(" not leap year");
        //}




        ////4.seniear citizen
        //int age;
        //Console.WriteLine("Enter age :");
        //age = Convert.ToInt32(Console.ReadLine());
        //if(age>=60)
        //{
        //    Console.WriteLine(" Give person is senior citizen");
        //}
        //else
        //{
        //    Console.WriteLine(" not seniear citizen");
        //}




        //5.check vowel and consonant 
        //Console.WriteLine(" Enter any character :");
        //char c = Convert.ToChar(Console.ReadLine());
        //if(c=='a'||c=='e'||c=='o'||c=='i'||c=='u'|| c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        //{
        //    Console.WriteLine("\n Given charater is vowel");
        //}
        //else
        //{
        //    Console.WriteLine("\n Given charater is Consonant");

        //}





        //6.check divisible by 5 and 11
        //int num;
        //Console.WriteLine("Enter any number to check divisible by 5 and 11 :");
        //num = int.Parse(Console.ReadLine());
        //if(num%5==0&& num%11==0)
        //{
        //    Console.WriteLine(" divisible by 5 and 11");
        //}
        //else
        //{
        //    Console.WriteLine(" not divisible by 5 and 11");

        //
        //}





        //7.WAP to check whether a person is eligible to vote or not
        //Console.WriteLine(" Enter your age: ");
        //int age = Convert.ToInt32(Console.ReadLine());
        //if(age>18)
        //{
        //    Console.WriteLine("Your eligible for the voating");
        //}
        //else
        //{
        //    Console.WriteLine("Your not eligible for the voating");

        //}




        //8. WAP to check whether a number is three digit or not
        //Console.WriteLine("Enter any number to check 3 digit or not :");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int count = 0;
        //for(int i=num;i>0;i/=10)
        //{

        //    count++;
        //}
        //if(count == 3)
        //{
        //    Console.WriteLine("Given  number is 3 digit number ");
        //}
        //else
        //{
        //    Console.WriteLine("Given  number is not 3 digit number ");
        //}




        //10. WAP to check whether a character is uppercase or lowercase a to z=97 to 122 A to Z =65 to 90
        //Console.WriteLine("Enter any char to check uppercase or lowercase :");
        //char c = Convert.ToChar(Console.ReadLine());
        //if( c>=65 && c<=90)
        //{
        //    Console.WriteLine(" Uppercase");
        //}
        //else
        //{
        //    Console.WriteLine(" Lowercase ");
        //}

        //--------------------------------------------------------------------------------------------------------------
        //use advance switch loop  /tarnary operator  /simple switch   /laders 

        ////1 tarnary operator
        //Console.WriteLine(" Enter any value in  between 1 to 4");
        //int num = Convert.ToInt32(Console.ReadLine());
        //string result = (num == 1) ? "pending" : (num == 2) ? "processing" : (num == 3) ? "rejecting" : "succesfull";
        //Console.WriteLine(result);

        ////2 laders
        //Console.WriteLine(" Enter any value in  between 1 to 4");
        //int num = Convert.ToInt32(Console.ReadLine());
        //if(num==1)
        //{ Console.WriteLine("pending"); }
        //else if(num==2)
        //{ Console.WriteLine("Processing"); }
        //else if(num==3)
        //{ Console.WriteLine("Rejected"); }
        //else
        //{ Console.WriteLine(" Invalid choice"); }

        //3 Simple Switch
        //Console.WriteLine(" Enter any value in  between 1 to 4");
        //int num = Convert.ToInt32(Console.ReadLine());
        //switch(num)
        //{
        //    case 1: Console.WriteLine("pending");
        //        break;
        //    case 2: Console.WriteLine(" Processing");
        //        break;
        //    case 3: Console.WriteLine("Rejected");
        //        break;
        //    case 4: Console.WriteLine("Successful");
        //        break;
        //    default:
        //        Console.WriteLine(" invalid choice");
        //        break;
        //}

        //4 advanced switch loop
        //Console.WriteLine("Enter number in between 1 to 7 to display day :");
        //int num = Convert.ToInt32(Console.ReadLine());

        //string result = num switch
        //{
        //    1 => "Monday",
        //    2 => "Tuesday",
        //    3 => "Wednesday",
        //    4 => "Thirsday",
        //    5 => "friday",
        //    6 => "saturday",
        //    7 => "sunday",
        //    _=>"Invalid input"

        //};

        //Console.WriteLine(result);


        //===================================================================================================================
        //-----IF ELSE-----//

        ////1.Write a C program to find the maximum between two numbers.
        //Console.WriteLine(" Enter any two number to check which one is gretest :");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //if (num1 > num2)
        //{
        //    Console.WriteLine($"{num1} is greater then {num2}");
        //}
        //else if (num1 < num2)
        //{
        //    Console.WriteLine($"{num1} is greater then {num1}");
        //}
        //else
        //{
        //    Console.WriteLine("both are same");
        //}




        ////2.Write a C program to find a maximum between three numbers.
        //Console.WriteLine("Enter any 3 number to find greatest one :\n");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //int num3 = Convert.ToInt32(Console.ReadLine());
        //if(num1>num2&&num1>num3)
        //{
        //    Console.WriteLine($"{num1} is greater than {num2} and {num3}");
        //}
        //else if(num2>num1&&num2>num3)
        //{
        //    Console.WriteLine($"{num2} id greater then {num1} and {num3}");
        //}
        //else if (num3 > num1 && num3 > num2)
        //{
        //    Console.WriteLine($"{num3} id greater then {num1} and {num2}");
        //}
        //else
        //{
        //    Console.WriteLine(" number are equal");
        //}



        ////3.Write a C program to check whether a number is negative, positive or zero.
        //Console.WriteLine("Enter any number to check positive or negative or zero :\n");
        //int num = Convert.ToInt32(Console.ReadLine());
        //string result = (num > 0) ? "positive number" : (num < 0) ? "Negative number" : "number is zero";
        //Console.WriteLine(result);



        ////4.Write a C program to check whether a number is divisible by 5 and 11 or not.
        //Console.WriteLine("Enter any number to check is divisible by 5 and 11 or not :");
        //int num = Convert.ToInt32(Console.ReadLine());
        //if(num%5==0 && num%11==0)
        //{
        //    Console.WriteLine($"{num} is divisible by both 5 and 11");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} is doesn't divide by both");
        //}




        ////5.Write a C program to check whether a number is even or odd.
        //Console.WriteLine("Enetr any number to check even or  odd:");
        //int num = Convert.ToInt32(Console.ReadLine());
        //string result = (num % 2 == 0) ? "even number" : "odd number";
        //Console.WriteLine($"{num} is {result}");





        //7.Write a C program to check whether a character is in the alphabet or not.
        //Console.WriteLine("Enter any character :");
        //char ch = Convert.ToChar(Console.ReadLine());
        //String result=((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) ? "alphabet" : "not alphabet";
        //Console.WriteLine($"{ch} is {result}");



        ////8.Write a C program to input any alphabet and check whether it is vowel or consonant.
        //Console.WriteLine("Enter any alphabate to check vowel or consonant :\n");
        //char ch = Convert.ToChar(Console.ReadLine());
        //string result = ((ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') || (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')) ? "Vowel" : "Consonant";
        //Console.WriteLine($"{ch} is {result}");



        ////9.Write a C program to input any character and check whether it is alphabet, digit or special character.
        //Console.WriteLine("Enter any character to check alphabet, digit or special character :");
        //char ch = Convert.ToChar(Console.ReadLine());
        //string result = ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) ? "Alphabate" : (ch >= '1' && ch <= '9') ? "digit" : "special character";
        //Console.WriteLine(result);





        ////10.Write a C program to check whether a character is uppercase or lowercase alphabet.
        //Console.WriteLine("Enter any alphabate to check it is lowercase or uppercase :");
        //char ch = Convert.ToChar(Console.ReadLine());
        //string result = (ch >= 'a' && ch <= 'z') ? "Lowercase" : (ch >= 'A' && ch <= 'Z') ? "Uppercase" : "Invalid input";
        //Console.WriteLine($"{ch} is {result}");




        ////11.write a C program to input week number and print week day.
        //Console.WriteLine("Enter any number in between 1 to 7 to print week day :\n");
        //int day = Convert.ToInt32(Console.ReadLine());
        //string result = (day == 1) ? "Monday" : (day == 2) ? "Tuesday" : (day == 3) ? "Wednesday" : (day == 4) ? "Thursday" : (day == 5) ? "Friday" : (day == 6) ? "Saturday" : (day == 7) ? "Sunday" : "Invalid input";
        //Console.WriteLine(result);



        ////12.Write a C program to input month number and print number of days in that month.
        //Console.WriteLine("Enter any month number to display their days :");
        //int mon = Convert.ToInt32(Console.ReadLine());
        //int result = (mon == 1 || mon == 3 || mon == 5 || mon == 7 || mon == 8 || mon == 10 || mon == 12) ? 31 : (mon == 2) ? 28 : 30;
        //Console.WriteLine($"their are {result} days in {mon} month");




        ////13.Write a C program to count total number of notes in given amount
        //Console.WriteLine("Enter the amount to finds notes");
        //int amount = Convert.ToInt32(Console.ReadLine());
        //int notes = 0;
        //if (amount >= 500)
        //{
        //    notes = amount / 500;
        //    Console.WriteLine("500 notes =>" + notes);
        //    amount = amount % 500;

        //}
        //if (amount >= 200)
        //{
        //    notes = amount / 200;
        //    Console.WriteLine("200 notes =>" + notes);
        //    amount = amount % 200;

        //}
        //if (amount >= 100)
        //{
        //    notes = amount / 100;
        //    Console.WriteLine("100 notes =>" + notes);
        //    amount = amount % 100;

        //}
        //if (amount >= 50)
        //{
        //    notes = amount / 50;
        //    Console.WriteLine("50 notes =>" + notes);
        //    amount = amount % 50;

        //}
        //if (amount >= 20)
        //{
        //    notes = amount / 20;
        //    Console.WriteLine("20 notes =>" + notes);
        //    amount = amount % 20;

        //}
        //if (amount >= 10)
        //{
        //    notes = amount / 10;
        //    Console.WriteLine("10 notes =>" + notes);
        //    amount = amount % 10;

        //}
        //if (amount >= 5)
        //{
        //    notes = amount / 5;
        //    Console.WriteLine("5 notes =>" + notes);
        //    amount = amount % 5;

        //}
        //if (amount >= 2)
        //{
        //    notes = amount / 2;
        //    Console.WriteLine("2 notes =>" + notes);
        //    amount = amount % 2;

        //}
        //if (amount >= 1)
        //{
        //    notes = amount / 1;
        //    Console.WriteLine("1 notes =>" + notes);
        //    amount = amount % 1;

        //}





        ////14.Write a C program to input angles of a triangle and check whether triangle is valid or not.
        //Console.WriteLine("Enter 3 angles of triangle :");
        //int ang1 = Convert.ToInt32(Console.ReadLine());
        //int ang2 = Convert.ToInt32(Console.ReadLine());
        //int ang3 = Convert.ToInt32(Console.ReadLine());
        //string result = (ang1 + ang2 + ang3 == 180) ? "valid" : "not valid";
        //Console.WriteLine("triangle is " + result);



        ////15.Write a C program to input all sides of a triangle and check whether triangle is valid or not.
        //Console.WriteLine(" Enter 3 sides of triangle :\n");
        //int s1 = Convert.ToInt32(Console.ReadLine());
        //int s2 = Convert.ToInt32(Console.ReadLine());
        //int s3 = Convert.ToInt32(Console.ReadLine());
        //string result = (s1 < (s2 + s3) && s2 < (s3 + s1) && s3 < (s1 + s2)) ? "valid " : "not valid";
        //Console.WriteLine($"Triangle is {result}");




        ////16.Write a C program to check whether the triangle is equilateral, isosceles or scalene triangle.
        //Console.WriteLine("Enter all side of triangle :");
        //int s1 = Convert.ToInt32(Console.ReadLine());
        //int s2 = Convert.ToInt32(Console.ReadLine());
        //int s3 = Convert.ToInt32(Console.ReadLine());
        //string result = (s1 == s2 && s2 == s3) ? "Equilateral Triangle" : (s1 == s2 || s2 == s3 || s3 == s1) ? "Isosceles triangle" : "scalene triangle";
        //Console.WriteLine("Given triangle is " + result);





        ////17.Write a C program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer.Calculate percentage and grade according to following:
        ////Percentage >= 90 % : Grade A
        ////Percentage >= 80 % : Grade B
        ////Percentage >= 70 % : Grade C
        ////Percentage >= 60 % : Grade D
        ////Percentage >= 40 % : Grade E
        //Console.WriteLine("Enter marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer :");
        //int phy = Convert.ToInt32(Console.ReadLine());
        //int che = Convert.ToInt32(Console.ReadLine());
        //int bio = Convert.ToInt32(Console.ReadLine());
        //int math = Convert.ToInt32(Console.ReadLine());
        //int comp = Convert.ToInt32(Console.ReadLine());
        //float percentage = (phy + che + bio + math + comp) / 5;
        //string result = (percentage >= 90) ? "Grade A" : (percentage >= 80) ? "Grade B" : (percentage >= 70) ? "Grade C" : (percentage >= 60) ? "Grade D" : (percentage >= 40) ? "Grade E" : "Fail";
        //Console.WriteLine($"Your result is :\n Percentage : {percentage } \n Grade : {result}");




        //================================================================================================================================
        //----switch case-----//




        ////1.Write a C program to print day of week name using switch case.
        //Console.WriteLine("Enter any number in between 1 to 7 to print their day in weeek :");
        //int day = Convert.ToInt32(Console.ReadLine());
        //string result = day switch
        //{
        //    1 => "Monday",
        //    2 => "Tuesday",
        //    3 => "Wednesday",
        //    4 => "thursday",
        //    5 => "friday",
        //    6 => "saturday",
        //    7 => "sunday",
        //    _ => "Invalid input"
        //};
        //Console.WriteLine(result);




        ////2.Write a C program print total number of days in a month using switch case.
        //Console.WriteLine("Enter month number in the year to print their number of days:");
        //int month = Convert.ToInt32(Console.ReadLine());
        //int result = month switch
        //{
        //    1=>31,2=>28,3=>31,4=>30,5=>31,6=>30,7=>31,8=>31,9=>30,10=>31,11=>30,12=>31,_=>0

        //};
        //if (result == 0)
        //{
        //    Console.WriteLine("Inavlid input");
        //}
        //else
        //{

        //    Console.WriteLine($"{result}days occurs in {month} month");
        //}



        ////3.Write a C program to check whether an alphabet is vowel or consonant using switch case.
        //Console.WriteLine("Enter any alphabate to check vowel consnant :\n");
        //char ch = Convert.ToChar(Console.ReadLine());
        //string result = ch switch
        //{
        //    'a' => "Vowel",
        //    'e' => "vowel",
        //    'i' => "vowel",
        //    'o' => "Vowel",
        //    'u' => "vowel",
        //    'A' => "vowel",
        //    'E' => "vowel",
        //    'I' => "vowel",
        //    'O' => "Vowel",
        //    'U' => "vowel",
        //    _ => "Consonant"
        //};
        //Console.WriteLine($"{ch} is {result}");



        ////4.Write a C program to find the maximum between two numbers using the switch case.
        //Console.WriteLine("Enter any two number to find greatest :\n");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //bool result = (num1 > num2);
        //int greater = result switch
        //{
        //    true => num1,
        //    false => num2
        //};
        //Console.WriteLine("Maximum  number is :" + greater);



        ////5.Write a C program to check whether a number is even or odd using a switch case.
        //Console.WriteLine("Enter any number to check even or odd");
        //int num = Convert.ToInt32(Console.ReadLine());
        //bool result = (num % 2 == 0);
        //string display = result switch
        //{
        //    true => "Even number",
        //    false=>"Odd Number"
        //};
        //Console.WriteLine($"{num} is {display}");



        ////6.Write a C program to create a Simple Calculator using a switch case.
        ///
        //Console.WriteLine("Enter first number and second number :\n");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the opearator do ou want to applay on that :");
        //char ch = Convert.ToChar(Console.ReadLine());
        //float result = ch switch
        //{
        //    '+' => num1 + num2,
        //    '-' => num1 - num2,
        //    '*' => num1 * num2,
        //    '/' => num1 / num2,
        //    '%' => num1 % num2,
        //    _ => 0
        //};
        //if (result == 0)
        //{
        //    Console.WriteLine("Invalid input ");
        //}
        //else
        //{
        //    Console.WriteLine($"\n {num1} {ch} {num2} = {result}");
        //}


        //========================================================================================================
        //-----task--------


        ////1.A user enters age.
        ////Display "Child", "Adult", or "Senior Citizen".
        //Console.WriteLine("Enter your age :");
        //int age = Convert.ToInt32(Console.ReadLine());
        //string result = (age > 0 && age < 18) ? "Child" : (age < 60) ? "Adult" : (age >= 60) ? "Senior citizen" : "invalid input";
        //Console.WriteLine(result);



        ////2.A student enters marks.
        ////Display Pass or Fail.
        //Console.WriteLine("Enter the marks of math,bio,chemistry,physics,electronic :");
        //int math=int.Parse(Console.ReadLine());
        //int bio = int.Parse(Console.ReadLine());
        //int che = int.Parse(Console.ReadLine());
        //int phy = int.Parse(Console.ReadLine());
        //int elec = int.Parse(Console.ReadLine());
        //float percentage = (math + bio + che + phy + elec) / 5;
        //string result= (percentage < 35) ? "Fail" :"Pass";
        //Console.WriteLine(result);



        ////3.A customer enters purchase amount.  
        ////If amount is more than 5000, apply discount.
        //Console.WriteLine("Enter purchase amount :");
        //int amount = Convert.ToInt32(Console.ReadLine());
        //float result=(amount>5000)? amount-(amount/10):amount;
        //Console.WriteLine("total -" + result);




        ////4.A user enters temperature.
        ////Display Cold, Normal, or Hot.
        //Console.WriteLine("Enter temperature :");
        //int temp = Convert.ToInt32(Console.ReadLine());
        //string result = (temp < 15) ? "Cold" : (temp < 30) ? "Normal" : "Hot";
        //Console.WriteLine(result);



        ////5.A user enters login status(true / false).  
        ////Display Login Successful or Login Failed.
        //Console.WriteLine("enters login status(true / false):");
        //string result = Console.ReadLine();
        //if (result == "true" || result == "TRUE" || result == "True")
        //{
        //    Console.WriteLine("Login Successful");
        //}
        //else
        //{
        //    Console.WriteLine("Login Failed");
        //}



        ////6.Employee salary calculation based on experience years.
        //Console.WriteLine("Enter your experiance in years:");
        //int experiance = Convert.ToInt32(Console.ReadLine());
        //if (experiance == 0)
        //{
        //    Console.WriteLine("Salary = 30000 per month");
        //}
        //else if (experiance > 0&& experiance<3)
        //{
        //    Console.WriteLine("Salary = 50000 per month");
        //}
        //else if (experiance >=3 && experiance < 5)
        //{
        //    Console.WriteLine("Salary = 70000 per month");
        //}
        //else if (experiance >=5 )
        //{
        //    Console.WriteLine("Salary = 100000 per month");
        //}



        ////7.Electricity bill calculation using units consumed.
        //Console.WriteLine("Enter consumed units :");
        //int units = Convert.ToInt32(Console.ReadLine());
        //if(units<=100)
        //{
        //    Console.WriteLine(" 2rs per unit \nTotal bill is :"+( 2 * units));
        //}
        //else if(units<=250)
        //{
        //    Console.WriteLine(" 3 rs per unit \n Total bill is :"+ (3 * units));

        //}
        //else if (units <= 500)
        //{
        //    Console.WriteLine(" 5 rs per unit \n Total bill is :"+( 5 * units));
        //}
        //else if(units>500)
        //{
        //    Console.WriteLine("7 rs per unit \n Total bill is :"+( 7 * units));
        //}
        //else
        //{
        //    Console.WriteLine("--units");
        //}


        //8.Income tax calculation based on salary slabs.



        ////9.Student grading system based on percentage.
        //Console.WriteLine("Enter your percentage :");
        //float percentage = float.Parse(Console.ReadLine());
        //string result = (percentage > 80) ? "A grade" : (percentage > 70) ? "B Grade" : (percentage > 60) ? "C garde" : (percentage >= 35) ? "D grade" : "fail";
        //Console.WriteLine(result);




        ////10.Shipping charge calculation based on delivery distance.
        //Console.WriteLine("Enter Delivery distance in km :");
        //int distance = Convert.ToInt32(Console.ReadLine());
        //if(distance <= 50)
        //{
        //    Console.WriteLine("shipping chargers 5rs per km \n total charge :" + (distance * 5));
        //}
        //else if (distance <= 100)
        //{
        //    Console.WriteLine("shipping chargers 7rs per km \n total charge :" + (distance * 7));
        //}
        //else if (distance <= 200)
        //{
        //    Console.WriteLine("shipping chargers 7rs per km \n total charge :" + (distance * 10));
        //}
        //else if (distance <= 500)
        //{
        //    Console.WriteLine("shipping chargers 7rs per km \n total charge :" + (distance * 12));
        //}
        //else if (distance > 500)
        //{
        //    Console.WriteLine("shipping chargers 7rs per km" + (distance * 15));
        //}



        ////11.ATM menu:
        ////1 → Balance
        ////2 → Withdraw
        ////3 → Deposit
        ////4 → Exit
        //Console.WriteLine("Enter Your Balance :");
        //int balance = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(" 1 : Balance \n 2 : Withdraw \n 3 : Deposit \n 4 : Exit \n Enter Your Choice :");
        //int choice = Convert.ToInt32(Console.ReadLine());
        //switch(choice)
        //{
        //    case 1 : Console.WriteLine("Avl Balance is :" + balance);
        //        break;
        //    case 2: Console.WriteLine("Enter the amount to withdraw :");
        //        int amount = Convert.ToInt32(Console.ReadLine());
        //        if(amount>balance)
        //        {
        //            Console.WriteLine("Insufficient balance ");
        //        }
        //        else
        //        {
        //            Console.WriteLine("withdraw amount :" + amount);
        //            Console.WriteLine("Remaning balance :" +(balance-amount));
        //        }
        //        break;
        //    case 3:
        //        Console.WriteLine("Enter Deposite amount :");
        //        int depo = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Deposite amount :" + depo);
        //        Console.WriteLine(" balance :" + (balance + depo));
        //        break;

        //    case 4:
        //        Console.WriteLine("Thank You For Visting");
        //        break;
        //    case 5:
        //        Console.WriteLine("Invalid choice");
        //        break;
        //}


        ////12.Restaurant menu selection using item number.
        //Console.WriteLine(" 1.Puran Poli \n 2.Misal Pav \n 3.Pav Bhaji \n 4. Chole Bhature \n 5.Dosa \n Choose Your menu :");
        //int ch = Convert.ToInt32(Console.ReadLine());
        //string result = ch switch
        //{
        //    1 => "Puran Poli is ready .Please Collect it from counter ",
        //    2 => "Misal Pav is ready .Please Collect it from counter",
        //    3 => "Pav Bhaji is ready .Please Collect it from counter",
        //    4 => "Chole Bhature is ready .Please Collect it from counter",
        //    5 => "Dosa is ready. Please Collect it from counter",
        //    _=> "Invalid choice"
        //};
        //Console.WriteLine(result);





        //13.Calculator menu using switch.
        //Console.WriteLine("Enter first number and second number :\n");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the opearator do ou want to applay on that :");
        //char ch = Convert.ToChar(Console.ReadLine());
        //float result = ch switch
        //{
        //    '+' => num1 + num2,
        //    '-' => num1 - num2,
        //    '*' => num1 * num2,
        //    '/' => num1 / num2,
        //    '%' => num1 % num2,
        //    _ => 0
        //};
        //if (result == 0)
        //{
        //    Console.WriteLine("Invalid input ");
        //}
        //else
        //{
        //    Console.WriteLine($"\n {num1} {ch} {num2} = {result}");
        //}



        ////14.Language selection:
        ////1 → English
        ////2 → Hindi
        ////3 → Marathi
        //Console.WriteLine(" 1:English \n 2:Hindi \n 3.Marathi \n Which Language you want to choose :");
        //int ch = Convert.ToInt32(Console.ReadLine());
        //string result = ch switch
        //{
        //    1 => "You select English Language",
        //    2 => "You select Hindi Language",
        //    3 => "You select Marathi Language",
        //    _ => "Invalid choice"
        //};
        //Console.WriteLine(result);




        ////15.Role - based access:
        ////Admin / User / Guest
        //Console.WriteLine("Choose Your Role : \n 1.Admin \n 2.User\n 3.Guest :");
        //int ch = Convert.ToInt32(Console.ReadLine());
        //string result = ch switch
        //{ 
        //    1=>"Full access",
        //    2=>"Limited Access",
        //    3=>"very limited access",
        //    _=>"No access"
        //};
        //Console.WriteLine(result);



        //SHORT LOGIC SCENARIOS(TERNARY)


        //16.Check user is active or inactive.
        //Console.WriteLine("Is User active entre yes or no :");
        //char ch = Console.ReadLine()[0];
        //string result = (ch == 'y' || ch == 'Y') ? "Active" : "Inactive";
        //Console.WriteLine("User is " + result);



        ////17.Display result based on attendance percentage.
        //Console.WriteLine("Enter your attendance percentage");
        //int per = Convert.ToInt32(Console.ReadLine());
        //string result = (per < 60) ? "Fail" : "Pass";
        //Console.WriteLine(result);


        ////18.Check stock availability.
        //Console.WriteLine("Enter count of stock");
        //int stock = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the number of stock you want");
        //int num = Convert.ToInt32(Console.ReadLine());
        //string result = (stock >= num) ? "Stock available" : "Stock not available";
        //Console.WriteLine(result);

        //19.Display success or error message.



        ////20.Check password is valid or invalid.
        //Console.WriteLine("Set your password :");
        //string spass = Console.ReadLine();
        //Console.WriteLine("Enter your password :");
        //string cpass = Console.ReadLine();
        //string result = (spass == cpass) ? "Valid" : "Invalid";
        //Console.WriteLine("passwors is " + result);





        //ADVANCED SWITCH SCENARIOS

        //21.Return discount percentage based on purchase amount.

        //22.Return shipping charge based on city name.


        //23.Return user message based on role.


        //24.Return grade based on marks.

        //25.Return salary bonus based on performance rating.


        //================================================================================================================

        //int sum = 0;
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        sum = sum + i;
        //    }
        //}
        //Console.WriteLine("Sum of even number in between  1 to 100 :" + sum);



        ////fibonacci series
        //int n1 = 0;
        //int n2 = 1;
        //int n = 20;
        //Console.Write($" {n1}   {n2} ");
        //for(int i=3;i<=n;i++)
        //{
        //    int n3 = n1 + n2;
        //    Console.Write("\t" + n3);
        //    n1 = n2;
        //    n2 = n3;
        //}

        ////a to z
        //for (char i ='A'; i <= 'z'; i++)
        //{

        //    if(i<=90||i>=97)
        //    {
        //        if(i==97)
        //        {
        //            Console.WriteLine("\n");
        //        }
        //        Console.Write("\t" + i);
        //    }
        //}


        //////prime number up to n
        //int n;
        //Console.WriteLine("Enter the value of range :");
        //n = Convert.ToInt32(Console.ReadLine());
        //for (int i = 2; i <= n; i++)
        //{
        //    int flag = 1;
        //     for (int j = 2; j <= i/2; j++)
        //     {
        //        if (i % j == 0)
        //        {
        //            flag = 0;
        //            break;
        //        }
        //     }
        //     if(flag==1)
        //    {
        //        Console.Write("\t" + i);
        //    }
        //}

        //=================================================================================================================

        //1.//Print numbers from 1 to 10 using WHILE loop.
        //int n = 1;
        //while (n <= 10)
        //{
        //    Console.Write(n + "\t");
        //    n++;
        //}
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.Write(i + "\t");
        //}


        //2.//Print numbers from 10 to 1 using WHILE loop.
        //int n = 10;
        //while(n>=1)
        //{
        //    Console.Write(n + "\t");
        //    n--;
        //}
        //Console.WriteLine("\n");
        //for(int i=10;i>=1;i--)
        //{
        //    Console.Write(i + "\t");
        //}


        //3.//Print even numbers between 1 and 20 using WHILE.
        //int n = 1;
        //while(n<=20)
        //{
        //    if(n%2==0)
        //    {
        //        Console.Write(n + "\t");
        //    }
        //    n++;
        //}
        //for(int i=1;i<=20;i++)
        //{
        //    if(i%2==0)
        //    {
        //        Console.Write(i + "\t");
        //    }
        //}


        //4.//Print odd numbers between 1 and 20 using WHILE
        //int n = 1;
        //while(n<=20)
        //{
        //    if(n%2!=0)
        //    {
        //        Console.Write(n + "\t");
        //    }
        //    n++;
        //}
        //for(int i=1;i<=20;i++)
        //{
        //    if(i%2!=0)
        //    {
        //        Console.Write(i + "\t");
        //    }
        //}


        //5//Calculate sum of numbers from 1 to 10 using WHILE loop.
        //int n = 1;
        //int sum= 0;
        //while(n<=10)
        //{
        //    sum += n;
        //    n++;
        //}
        //for(n=1;n<=10;n++)
        //{
        //    sum = sum + n;
        //}
        //Console.WriteLine("sum of 1 to 10 numbers is :" + sum);


        //6//Calculate factorial of a number using WHILE loop.
        //Console.WriteLine("Enter the number up to u want factorial :");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int n1 = 0, n2 = 1, i = 3;
        //Console.Write($"{n1}\t{n2}\t");
        //while(i<=n)
        //{
        //    int n3 = n1 + n2;
        //    Console.Write(n3 + "\t");
        //    n1 = n2;
        //    n2 = n3;
        //    i++;
        //}


        //7//Count total digits in a number using WHILE loop.
        //Console.WriteLine("Enter any number to find digit:");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int count = 0;
        //while (n > 0)
        //{
        //    count++;
        //    n = n / 10;
        //}
        //for (int i = n; i > 0; count++, i /= 10) ;
        //Console.WriteLine(" No of digit in given number is :" + count);


        //8//Reverse a number using WHILE loop.
        //Console.WriteLine("Enter any number :");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int rev = 0;
        //while(n>0)
        //{
        //    int digit = n % 10;
        //    rev = rev * 10 + digit;
        //    n = n / 10;
        //}
        //    for(int i=n;i>0;i/=10)
        //    {
        //        int digit = i % 10;
        //        rev = rev * 10 + digit;
        //    }
        //    Console.WriteLine("Reverse number is :" + rev);


        ////9//Check whether a number is palindrome using WHILE loop.
        //Console.WriteLine("Enter any number to check palindrome or not :");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int rev=0;
        //for(int i=n;i>0;i/=10)
        //{
        //    int digit = i % 10;
        //    rev = rev * 10 + digit;
        //}
        //string result = (n == rev) ? "Palindrome" : "noy palindrome";
        //Console.WriteLine($"{n} is {result}"); 


        //10//Print multiplication table of a number using WHILE loop.
        //Console.WriteLine("Enter any number to print their multiplication table :");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int i = 1;
        //while(i<=10)
        //{
        //    Console.WriteLine($"{n} x {i} = {n * i}");
        //    i++;
        //}
        //for(int i=1;i<=10;i++)
        //{
        //    Console.WriteLine($"{n} x {i} = {n * i}");
        //}


        //11//Find sum of even digits of a number using WHILE loop.
        //Console.WriteLine("Enter any digit to find sum of even digit of number :");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //while(num>0)
        //{
        //    int digit = num % 10;
        //    if(digit%2==0)
        //    {
        //        sum = sum + digit;
        //    }
        //    num/= 10;
        //}
        //Console.WriteLine("sum of even digit :" + sum);



        ////12//Find sum of odd digits of a number using WHILE loop.
        //Console.WriteLine("Enter any number :");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //for(int i=num;i>0;i/=10)
        //{
        //    int digit = i % 10;
        //    if(digit%2!=0)
        //    {
        //        sum = sum + digit;
        //    }
        //}
        //Console.WriteLine("sum of odd digit :" + sum);



        ////13//Count even numbers between 1 and 50 using WHILE loop.
        //int count = 0;
        //for(int i=1;i<=50;i++)
        //{
        //    if(i%2==0)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine("count of even number in 1 to 50 is " + count);


        //14//Find power of a number (a^b) using WHILE loop.
        //Console.WriteLine("Enter any number :");
        //int num = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter power:");
        //int p = Convert.ToInt32(Console.ReadLine());
        //int mult = 1;
        //for(int i=1;i<=p;i++)
        //{
        //    mult = mult * num;
        //}
        //Console.WriteLine(mult);



        //15//Print first 10 natural numbers using WHILE loop.
        //int n = 1;
        //while(n<=10)
        //{
        //    Console.Write(n + "\t");
        //    n++;
        //}

        //for(int i=5;i>=1;i--)
        //{
        //    for(int j=5;j>=i;j--)
        //    {
        //        Console.Write("_");
        //    }
        //    for(int k=1;k<=i*2-1;k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}




        //1//Number pattern 1
        //11111
        //00000
        //11111
        //00000
        //11111
        //int n = 1;
        //  for(int i=1;i<=5;i++)
        //  {
        //    for(int j=1;j<=5;j++)
        //    {
        //        Console.Write(n);
        //    }
        //    Console.WriteLine();
        //   n= (n == 1) ? 0 :1;
        //  }




        //2//Number pattern 2
        //01010
        //01010
        //01010
        //01010
        //01010
        //int n;
        //  for(int i=1;i<=5;i++)
        //  { n = 0;
        //    for(int j=1;j<=5;j++)
        //    {
        //        Console.Write(n);
        //        n = (n == 0) ? 1 : 0;
        //    }
        //    Console.WriteLine();
        //  }



        //3//Number pattern 3

        //11111
        //10001
        //10001
        //10001
        //11111
        //  for(int i=1;i<=5;i++)
        //  {
        //    for(int j=1;j<=5;j++)
        //    {
        //        if(i==1||i==5||j==1||j==5)
        //        {
        //            Console.Write("1");
        //        }
        //        else
        //        {
        //            Console.Write("0");
        //        }
        //    }
        //    Console.WriteLine();
        //}




        //4//Number pattern 4

        //11111
        //11111
        //11011
        //11111
        //11111
        //  for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        if(i==j&& i==3)
        //        {
        //            Console.Write("0");
        //        }
        //        else
        //        {
        //            Console.Write("1");
        //        }
        //    }
        //    Console.WriteLine();
        //}



        //5//Number pattern 5

        //10101
        //01010
        //10101
        //01010
        //10101
        //int n = 1;
        //  for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        Console.Write(n);
        //        n = (n == 0) ? 1 : 0;
        //    }
        //    Console.WriteLine();
        //}



        //6//Number pattern 6

        //11011
        //11011
        //00 00
        //11011
        //11011
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        if(i==3||j==3)
        //        {
        //            if (i == j && i == 3)
        //            {
        //                Console.Write(" ");
        //            }
        //            else
        //            {
        //                Console.Write("0");
        //            }
        //        }
        //        else
        //        {
        //            Console.Write("1");
        //        }
        //    }
        //    Console.WriteLine();
        //}




        //7//Number pattern 7

        //10001
        //01010
        //00100
        //01010
        //10001
        //for(int i = 1;i <= 5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        if(i==j||i+j==6)
        //        {
        //            Console.Write("1");
        //        }
        //        else
        //        {
        //            Console.Write("0");
        //        }
        //    }
        //    Console.WriteLine();
        //}


        //8//Number pattern 8
        //01110
        //10001
        //10001
        //10001
        //01110
        //for (int i = 1; i <= 5; i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        if ((i == 1||j==1||i==5||j==5)&&i!=j&&i+j!=6)
        //        {
        //            Console.Write("0");
        //        }
        //        else
        //        {
        //            Console.Write("1");
        //        }
        //    }
        //    Console.WriteLine();
        //}


        ////Number pattern 9
        //11111
        //22222
        //33333
        //44444
        //55555

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //}



        ////Number pattern 10
        //12345
        //12345
        //12345
        //12345
        //12345
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}


        ////Number pattern 11
        //12345
        //23456
        //34567
        //45678
        //56789

        //for(int i=1;i<=5;i++)
        //{
        //    int k = i;
        //    for(int j=1;j<=5;j++)
        //    {
        //        Console.Write(k);
        //        k++;
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 12

        //1  2  3  4  5
        //6  7  8  9  10
        //11 12 13 14 15
        //16 17 18 19 20
        //21 22 23 24 25\
        //int k = 1;
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        Console.Write(k+" ");
        //        k++;
        //    }
        //    Console.WriteLine();
        //}


        ////Number pattern 13
        //55555
        //54444
        //54333
        //54322
        //54321

        //for (int i = 5; i >= 1; i--)
        //{
        //    for (int j = 5; j >= i; j--)
        //    {
        //        Console.Write(j);
        //    }
        //    for (int k = 1; k < i; k++)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //}


        //Number pattern 14

        //12345
        //23455
        //34555
        //45555
        //55555

        //for (int i=1;i<=5;i++)
        //{
        //    int n = i;
        //    for (int j = 5; j >= i; j--)
        //    {
        //        Console.Write(n);
        //        n++;
        //    }

        //    for(int k=2;k<=i;k++)
        //    {
        //        Console.Write("5");
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 15

        //12345
        //23451
        //34521
        //45321
        //54321

        //for(int i=1;i<=5;i++)
        //{
        //    int n = i;
        //    for(int j=5;j>=i;j--)
        //    {
        //        Console.Write(n);
        //        n++;
        //    }
        //    int m = i - 1 ;
        //    for(int k=1;k<i;k++)
        //    {
        //        Console.Write(m);
        //        m--;
        //    }
        //    Console.WriteLine();
        //}


        ////Number pattern 16

        //12345
        //21234
        //32123
        //43212
        //54321
        //for(int i=1;i<=5;i++)
        //{
        //    int n = i;
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //        n--;
        //    }
        //    int m = 2;
        //    for(int k=5;k>i;k--)
        //    {
        //        Console.Write(m);
        //        m++;
        //    }
        //    Console.WriteLine();
        //}


        ////Number pattern 19

        //  1
        //  22
        //  333
        //  4444
        //  55555
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //}



        ////Number pattern 20

        //55555
        //4444
        //333
        //22
        //1

        //for(int i=5;i>=1;i--)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 21

        //11111
        //2222
        //333
        //44
        //5

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=5;j>=i;j--)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 22

        //5
        //44
        //333
        //2222
        //11111

        //for(int i=5;i>=1;i--)
        //{
        //    for(int j=5;j>=i;j--)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 23

        //1
        //12
        //123
        //1234
        //12345

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}




        //Number pattern 24

        //12345
        //1234
        //123
        //12
        //1

        //for(int i=5;i>=1;i--)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}





        //Number pattern 25

        //1
        //21
        //321
        //4321
        //54321

        //for(int i=1;i<=5;i++)
        //{
        //    int n = i;
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //        n--;
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 26

        //54321
        //4321
        //321
        //21
        //1

        //for(int i=5;i>=1;i--)
        //{
        //    int n = i;
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //        n--;
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 27

        //5
        //54
        //543
        //5432
        //54321

        //for(int i=5;i>=1;i--)
        //{
        //    int n = 5;
        //    for(int j=5;j>=i;j--)
        //    {
        //        Console.Write(n);
        //        n--;
        //    }
        //    Console.WriteLine();
        //}


        //Number pattern 28

        //54321
        //5432
        //543
        //54
        //5
        //for(int i = 5;i>=1;i--)
        //{
        //    int n = 5;
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //        n--;
        //    }
        //    Console.WriteLine();
        //}


        //Number pattern 29

        //5
        //45
        //345
        //2345
        //12345

        //for(int i=5;i>=1;i--)
        //{
        //    int n = i;
        //    for(int j=5;j>=i;j--)
        //    {
        //        Console.Write(n);
        //        n++;
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 30

        //12345
        //2345
        //345
        //45
        //5

        //for(int i=1;i<=5;i++)
        //{
        //    int n = i;
        //    for(int j=5;j>=i;j--)
        //    {
        //        Console.Write(n);
        //        n++;
        //    }
        //    Console.WriteLine();
        //}


        //Number pattern 31

        //1
        //23
        //345
        //4567
        //56789
        //for(int i=1;i<=5;i++)
        //{
        //    int n = i;
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //        n++;
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 32

        //56789
        //4567
        //345
        //23
        //1

        //for(int i=5;i>=1;i--)
        //{
        //    int n = i;
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //        n++;
        //    }
        //    Console.WriteLine();
        //}


        //Number pattern 33

        //13579
        //3579
        //579
        //79
        //9
        //for(int i=1;i<=10;i+=2)
        //{
        //    int n = i;
        //    for(int j=10;j>=i;j-=2)
        //    {
        //        Console.Write(n);
        //        n += 2;
        //    }
        //    Console.WriteLine();
        //}



        //Triangle 0,1 easy patterns

        //1
        //10
        //101
        //1010
        //10101

        //for(int i=1;i<=5;i++)
        //{
        //    int n = 1;
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //        n = (n == 0) ? 1 : 0;
        //    }
        //    Console.WriteLine();
        //}



        //Number pattern 35

        //1
        //00
        //111
        //0000
        //11111
        //int n = 1;
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //    }
        //    n = (n == 1) ? 0 : 1;
        //    Console.WriteLine();
        //}


        //Number pattern 36

        //1
        //01
        //010
        //1010
        //10101
        //int n = 1;
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(n);
        //        n = (n == 0) ? 1 : 0;
        //    }
        //    Console.WriteLine();
        //}

        //Number pattern 37

        //1
        //11
        //101
        //1001
        //11111
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        if(j==1||i==5||i==j)
        //        {
        //            Console.Write("1");
        //        }
        //        else
        //        {
        //            Console.Write("0");
        //        }
        //    }
        //    Console.WriteLine();
        //}


        //Number pattern 38
        //1  2  3
        //6  5  4
        //7  8  9
        //12 11 10
        //int n = 1;
        //for(int i=1;i<=4;i++)
        //{
        //    for(int j=1;j<=3;j++)
        //    {
        //        if(i%2!=0)
        //        {
        //            Console.Write(n+" ");
        //            n++;
        //        } 
        //        else
        //        {
        //            Console.Write(n+" ");
        //            n--;
        //        }
        //    }
        //    n = (i % 2 != 0) ? n + 2: n + 4;
        //    Console.WriteLine();
        //}



        //STAR PATTERN

        //*****
        //*****
        //*****
        //*****
        //*****
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}



        //1.Square

        //*****
        //*   *
        //*   *
        //*   *
        //*****

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=5;j++)
        //    {
        //        if(i==1||i==5||j==1||j==5)
        //        {
        //            Console.Write("*");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    Console.WriteLine();
        //}



        //2.Hollow Square

        //    *****
        //   *****
        //  *****
        // *****
        //*****

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=4;j>=i;j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int k=1;k<=5;k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}


        //3.Rhombus

        //    *****
        //   *   *
        //  *   *
        // *   *
        //*****

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=4;j>=i;j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int k=1;k<=5;k++)
        //    {
        //        if(i==1||i==5||k==5||k==1)
        //        {
        //            Console.Write("*");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    Console.WriteLine();
        //}


        //4.Hollow Rhombus

        //*****
        // *****
        //  *****
        //   *****
        //    *****

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int k=1;k<=5;k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}



        //5.Mirrored Rhombus

        // *****
        // *    *
        //  *    *
        //   *    *
        //    *****
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int k=1;k<=5;k++)
        //    {

        //    }
        //}


        //6.Hollow mirrored Rhombus

        //*
        //**
        //***
        //****
        //*****
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}


        //7.Right triangle

        //*
        //**
        //* *
        //*  *
        //*****
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        if(i==5||j==1||i==j)
        //        {
        //            Console.Write("*");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    Console.WriteLine();
        //}



        //8.Hollow right triangle

        //    *
        //   * *
        //  * * *
        // * * * *
        //* * * * *

        //for(int i=1;i<=5;i++)
        //{
        //    for(int k=4;k>=i;k--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}



        //9.Mirrored right triangle

        //    *
        //   * *
        //  *   *
        // *     *
        //* * * * *
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=4;j>=i;j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int k=1;k<=i;k++)
        //    {
        //        if(i==5||k==1||i==k)
        //        {
        //            Console.Write("* ");
        //        }
        //        else
        //        {
        //            Console.Write("  ");
        //        }
        //    }
        //    Console.WriteLine();
        //}


        //10.Hollow mirrored right triangle

        // *****
        // ****
        // ***
        // **
        // *

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=5;j>=i;j--)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}



        //11.Inverted right triangle

        //*****
        //*  *
        //* *
        //**
        //*
        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=5;j>=i;j--)
        //    {
        //        if(j==5||i==1||i==j)
        //        {
        //            Console.Write("*");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    Console.WriteLine();
        //}



        //12.Hollow inverted right triangle

        // * * * * *
        //  * * * *
        //   * * *
        //    * *
        //     *

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=1;j<=i;j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int k=5;k>=i;k--)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}



        //13.Inverted mirrored right triangle

        //  *****
        //  *  *
        //  * *
        //  **
        //  *

        //for(int i=1;i<=5;i++)
        //{
        //    for(int j=5;j>=i;j--)
        //    {
        //        if(j==5||i==1||i==j)
        //        {
        //            Console.Write("*");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //1 2 3 4 5
        //10 9 8 7 6
        //11 12 13 14 15
        //20 19 18 17 16

        //for(int i=1;i<=5;i++)
        //{
        //    int n = 1;
        //    for(int j=1;j<=5;j++)
        //    {
        //        if(i%2!=0)
        //        {
        //            Console.Write(n);
        //            n++;
        //        }
        //        else
        //        {
        //            Console.Write(n);
        //            n--;
        //        }
        //    }
        //    Console.WriteLine();
        //    if(i%2!=0)?n+=4:
        //}

        //=============================================================================================================================================
        //=============================================================================================================================================
        //=============================================================================================================================================
        //__________________  FUNCTIONS  ________________________


        //public static void  PercentageAndGrade(int phy,int chemis,int bio,int math,int elec)
        //{
        //    int per = (phy + chemis + bio + elec + math) / 5;
        //    Console.WriteLine("Percentage => " + per);
        //    string grade = (per >= 80) ? "A" : (per >= 70) ? "B" : (per >= 60) ? "C" : (per >= 50) ? "D" : (per >= 35) ? "E" : "F";
        //    Console.WriteLine("Grade => " + grade);
        //}

        //public static void Main(string[] args)
        //{

        //Call funvtion in the same class where main method is present 

        ////calculate grade and percentage
        //Console.WriteLine("Enter the marks out of 100 for \n1.Physics \n2.Chemistry\n3.Biology\n4.Math\n5.Electronics");
        //int phy = Convert.ToInt32(Console.ReadLine());
        //int chemis = Convert.ToInt32(Console.ReadLine());
        //int bio = Convert.ToInt32(Console.ReadLine());
        //int math = Convert.ToInt32(Console.ReadLine());
        //int elec = Convert.ToInt32(Console.ReadLine());
        //PercentageAndGrade(phy, chemis, bio, math, elec);



        //======================================================================================================================================
        //Static fuction 
        //All If Else and switch Examples




        //int n1 = 5, n2 = 6, n3 = 7;
        //int num = 145;
        //int result=MathFunction.GetMax(n1,n2,n3);
        //Console.WriteLine($"Max number in {n1} ,{n2} and {n3} is {result} ");


        //result = MathFunction.GetSum(n1);
        //Console.WriteLine($"addtion up to {n1} is {result} ");


        //bool res1 = MathFunction.Strong(num);
        //string s = (res1 == true) ? "Strong" : "Not strong";
        //Console.WriteLine($"{num}  is {s} number ");



        //Console.WriteLine("Enter any number to check even or odd :");
        //num = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{num} is {MathFunction.EvenOdd(num)}");


        //Console.WriteLine("Enter any number to check divisible by both 5 and 11 :");
        //num = Convert.ToInt32(Console.ReadLine());
        //if(MathFunction.DivisibleBoth(num)==true)
        //{
        //    Console.WriteLine($"{num} is divisible by both 5 and 11");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} is does not divisible by both 5 and 11");
        //}


        //Console.WriteLine("Enter any year to check leap or not :");
        //int year = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{year} is {MathFunction.LeapYear(year)}");


        //Console.WriteLine("Enter any character to check alphabate or not :");
        //char c = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine($"Given {c} is {MathFunction.CheckAlphabet(c)}");


        //Console.WriteLine("Enter any alphabate to check vowel or consonant :");
        //c = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine($"{c} is {MathFunction.CheckVowel(c)}");


        //Console.WriteLine("Enter any character to check alphabate or digit or special character  :");
        //c = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine($"Given {c} is {MathFunction.CheckCharacter(c)}");


        //Console.WriteLine("Enter any alphabate to check Uppercase or Lowercase :");
        //c = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine($"{c} is {MathFunction.CheckUppercase(c)}");


        //Console.WriteLine("Enter any number to print day of week :");
        //num = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"For the number {num} is {MathFunction.WeekDay(num)} ");


        //Console.WriteLine("Enter any number to print day of month:");
        //num = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"For the number {num} is {MathFunction.DaysInMonth(num)} ");


        //Console.WriteLine("entre the amount to count notes :");
        //int amount = Convert.ToInt32(Console.ReadLine());
        //MathFunction.CountNotes(amount);


        //Console.WriteLine("Enetr the angle of triangle :");
        //int ang1 = Convert.ToInt32(Console.ReadLine());
        //int ang2 = Convert.ToInt32(Console.ReadLine());
        //int ang3 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Given triangle is " + MathFunction.ValidTriangle(ang1, ang2, ang3));



        //=====================================================================================================================================
        //call by instance
        //All pattern Example


        //Patterns p = new Patterns();
        //p.NumberPattern1();
        //Console.WriteLine();

        //p.NumberPattern2();
        //Console.WriteLine();

        //p.NumberPattern3();
        //Console.WriteLine();

        //p.NumberPattern4();
        //Console.WriteLine();

        //p.NumberPattern5();
        //Console.WriteLine();

        //p.NumberPattern6();
        //Console.WriteLine();

        //p.NumberPattern7();
        //Console.WriteLine();

        //p.NumberPattern8();
        //Console.WriteLine();

        //p.NumberPattern9();
        //Console.WriteLine();

        //p.NumberPattern10();
        //Console.WriteLine();

        //p.NumberPattern11();
        //Console.WriteLine();

        //p.NumberPattern12();
        //Console.WriteLine();

        //p.NumberPattern13();
        //Console.WriteLine();

        //p.NumberPattern14();
        //Console.WriteLine();

        //p.NumberPattern15();
        //Console.WriteLine();

        //p.NumberPattern16();
        //Console.WriteLine();

        //p.NumberPattern19();
        //Console.WriteLine();

        //p.NumberPattern20();
        //Console.WriteLine();

        //p.NumberPattern21();
        //Console.WriteLine();

        //p.NumberPattern22();
        //Console.WriteLine();

        //p.NumberPattern23();
        //Console.WriteLine();

        //p.NumberPattern24();
        //Console.WriteLine();

        //p.NumberPattern25();
        //Console.WriteLine();

        //p.NumberPattern26();
        //Console.WriteLine();

        //p.NumberPattern27();
        //Console.WriteLine();

        //p.NumberPattern28();
        //Console.WriteLine();

        //p.NumberPattern29();
        //Console.WriteLine();

        //p.NumberPattern30();
        //Console.WriteLine();

        //p.NumberPattern31();
        //Console.WriteLine();

        //p.NumberPattern32();
        //Console.WriteLine();

        //p.NumberPattern33();
        //Console.WriteLine();

        //p.NumberPattern34();
        //Console.WriteLine();

        //p.NumberPattern35();
        //Console.WriteLine();

        //p.NumberPattern36();
        //Console.WriteLine();

        //p.NumberPattern37();
        //Console.WriteLine();

        //p.NumberPattern38();
        //Console.WriteLine();

        //p.StarPattern1();
        //Console.WriteLine();

        //p.StarPattern2();
        //Console.WriteLine();

        //p.StarPattern3();
        //Console.WriteLine();

        //p.StarPattern4();
        //Console.WriteLine();

        //p.StarPattern5();
        //Console.WriteLine();

        //p.StarPattern6();
        //Console.WriteLine();

        //p.StarPattern7();
        //Console.WriteLine();

        //p.StarPattern8();
        //Console.WriteLine();

        //p.StarPattern9();
        //Console.WriteLine();

        //p.StarPattern10();
        //Console.WriteLine();

        //p.StarPattern11();
        //Console.WriteLine();

        //p.StarPattern12();
        //Console.WriteLine();

        //p.StarPattern13();
        //Console.WriteLine();
        //}





        //=================================================================================================================================================
        //=================================================================================================================================================
        //=================================================================================================================================================
        //___________ref and out keyuword 


        //ref defination 
        //The ref keyword is used to pass a variable by reference to a method.
        //This means changes made inside the method affect the original variable.
        //Variable must be initialized before passing
        //ref keyword must be used : In method definition or In method call
        
        public static void Swap(ref int a,ref int b)
        {
            Console.WriteLine($"before swapping  a :{a}  b :{b}");

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"after swapping   a :{a} b :{b}");
        }

        public static int SetDoubleValue(ref int num) =>num= num * 2;

        //out keyword
        //Used to return multiple values from a function
        //Variable does NOT need to be initialized before passing
        //Method must assign a value to out variable


        //eg suppose i create one function for add and sub but i ony return add and sub return through the out variable
        public static int SumAndSub(ref int a,ref int b,out int sub)
        {
            sub = a - b;
            return a + b;
        }
        //public static void Main(string[] args)
        //{
        //int n1 = 65, n2 = 87;
        //Console.WriteLine($"Value before function call \n n1:{n1} n2:{n2} ");
        //Swap(ref n1, ref n2);
        //Console.WriteLine($"Value after call function by variable using ref keyword \n n1:{n1} n2:{n2}");

        //int num = 60;
        //Console.WriteLine($"before call function num :{num}");
        //Console.WriteLine($"Function call its return double value :" + SetDoubleValue(ref num));
        //Console.WriteLine($"After call function num :{num}");

        //that means value of n1 and n2 is passes for a and b also
        //after opeation change the value of a and b also n1 and n2

        //ref 
        //int a = 10,b=5,sub;
        //int sum = SumAndSub(ref a, ref b, out sub);
        //Console.WriteLine($"Addition :{sum} \nSubtraction :{sub}");

        //}


        //=================================================================================================================================================
        
        //___________Delegate
        //Delegate is like a reference (pointer) to a method.
        //A delegate can store a function and call it later.
        //Delegate = container for a method
        //You don’t know which function will run now .But you know what type of function .Delegate decides which function to call at runtime
        //lambada or anonomus or arrow function 
        //predicted delecate we only pass argument 

        //public static string Prime(int a)
        //{
        //    int flag = 0;
        //    for (int i = 2; i <= a / 2; i++)
        //    {
        //        if (a % i == 0)
        //        {
        //            flag = 0;
        //            break;
        //        }
        //        else
        //        {
        //            flag = 1;
        //        }
        //    }
        //    string res = (flag == 1) ? "Prime Number" : "Not Prime";
        //    return res;
        //}

        //public static void sub(int a, int b)
        //{
        //    Console.WriteLine(a - b);
        //}
        //delegate void subtract(int x, int y);

        //public static void Main(string[] args)
        //{



        //========================================================================================================================
        //Simple Delegate

        //1//substraction
        //subtract calc = new subtract(sub); we can also point like //subtract calc=sub;
        //subtract calc = sub;
        //calc(40, 20);



      



        //=======================================================================================================================
        //Generic delegate

        //1.Func Delegate
        //Func<int, string> P = Prime;
        //Console.WriteLine(P(6));



        //========================================================================================================================
        //delegate with lambda function

        //1//check mail is valid or not
        //Predicate<string> isValid = (email) =>
        //{
        //    return email.Contains("@");
        //};
        //string email = "maithili.pise2003@gmail.com";
        //Console.WriteLine($" email is valid =" + isValid(email));



        //2//check prime by using predicted eith lambda
        //Predicate <int> isPrime = (n) =>
        //{
        //    bool flag = true;
        //    for (int i = 2; i <= n / 2; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            flag = false;
        //            break;
        //        }
        //        else
        //        {
        //            flag = true;
        //        }
        //    }
        //    return flag;
        //};
        //int num = 563;

        //Console.WriteLine($" {num} is prime number =>{isPrime(num)}");
        //}


        

        //========================================================================================================================

        //Generic Method 



        //public static void Compare<T>(T n1,T n2)
        //{
        //    Console.WriteLine($" first is {n1} and second is {n2}");
        //}
        //public static void Main(string[] args )
        //{

        //    //Write a C# program to demonstrate a generic class.
        //    GenericDemo<int> obj = new GenericDemo<int>();
        //    obj.Show(83);

        //    //Write a C# program to demonstrate a generic method.
        //    Compare<int>(53, 74);

        //    //Write a C# program to store and display values using Generics.


        //    //Write a C# program to swap two values using a generic method.
        //    string n1 = "Maithili", n2 = "Shivtej";
        //    GenericDemo<string> gen = new techrel.GenericDemo<string>();
        //    gen.Swap(ref n1, ref n2);

        //    //Write a C# program to create a generic calculator.

        //}



        //In Class StringOperation

        //simple delegate
        //public delegate string mydel(string str1,string str2);

        //public static void Main(string[] args)
        //{
        //    mydel s1 = StringOperation.ConcatenateStrings;
        //    string result = s1("Hello", "Maithili");
        //    Console.WriteLine(result);
        //}
    }
}