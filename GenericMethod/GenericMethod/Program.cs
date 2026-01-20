using System;
namespace GenericMethod;

public class Program
{

    //Generic method

    
    public static void Display <T>(T value)
    {
        Console.WriteLine("Given value is " + value);
    }

    public void Swap<T>(ref T value1,ref T value2)
    {
        T value3 = value1;
        value1 = value2;
        value2 = value3;
    }
    public static void Main(String[] args)
    {
        //Genric Method

        //1.when method in same class and also static
        //Display("MAITHILI");
        //Display(63);


        //2.when method is  non static and in the same class
        //Program p = new Program();
        //string name1 = "Maithili", name2 = "Shivtej";
        //Console.WriteLine($"Before swapping  Nmae1 = {name1}  name2 = {name2}");
        //p.Swap(ref name1, ref name2);
        //Console.WriteLine($"After swapping   Nmae1 = {name1}  name2 = {name2}");
        //int val1 = 64, val2 = 74;
        //Console.WriteLine($"Before swapping  Nmae1 = {val1}  name2 = {val2}");
        //p.Swap(ref val1, ref val2);
        //Console.WriteLine($"After swapping   Nmae1 = {val1}  name2 = {val2}");


        //3.When method is static and in another class
        //class1.Sum("Hii ", "Maithili");
        //class1.Sum<int>(45, 45);
        //class1.Sum(23.5, 32.3);


        //4.When method is non-static and in another class
        //int MaxNo; we can directly datatype when we call method
        //class1 obj = new class1();
        //obj.Max<int>(64, 82, out int MaxNo);
        //Console.WriteLine(MaxNo);
        //obj.Max<float>(64.4f, 82.5f, out float max);
        //Console.WriteLine(max);


        //============================================================================================================================


        //Generic class

        //when method in another generic class and its static

        GenericClass<string>.DisplayMassage("good morning");


        //when method in another generic class and its non-static

        GenericClass<int> obj = new GenericClass<int>();
        int val1 = 546,val2=46;
        obj.Swapping(ref val1,ref val2);
        Console.WriteLine($" Val1: {val1} val2: {val2}");

        GenericClass<string> obj2 = new GenericClass<string>();
        obj2.Add("Maithili", "Tanaji", "Pise", out string sum);
        Console.WriteLine(sum);


    }
}