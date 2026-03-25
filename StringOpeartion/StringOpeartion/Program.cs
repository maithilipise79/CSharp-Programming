
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

public class Program
{
    public static void Main(String[] args)
    {

        ArrayList list = new ArrayList();
        list.Add(11);
        list.Add("raju");
        list.Add(true);
        list.Add(false);
        list.Add(9.7);
        foreach(Object i in list)
            Console.WriteLine(i);



        //Class Work
        //11/03/2026


        //public static void Main(string[] arg)
        //{
        //string s = "raju";
        //s = "Abhinav Yadav";
        //Console.WriteLine(s.Length);
        //Console.WriteLine(s[15]);



        //string s1 = "raju";
        //string s2 = "raju";
        //Console.WriteLine(s1.ToUpper()); 
        //Console.WriteLine(s1);
        //Console.WriteLine(s2);

        //string s = new string("raju");
        //string s1 = s;
        //s.ToUpper();
        //Console.WriteLine(s1);
        //string s = "Raju";
        //string s1 = "Raju";
        //s = s.Trim().ToLower();
        //Console.WriteLine(s);
        //Console.WriteLine(s1);

        //Console.WriteLine("Addition is " +(10+20));
        //Console.WriteLine($"Addition is {10+20}");
        //string name = "";
        //if (string.IsNullOrWhiteSpace(name))
        //{
        //    Console.WriteLine("Hii string is Null ");
        //}
        //else
        //{
        //    Console.WriteLine("string not null");
        //}

        //string s = new string( "raju");
        //string s1 =new string("raju");
        //Console.WriteLine(s == s1);
        //Console.WriteLine(s1.Equals(s));

        //string s = "23456789";
        //var res= s.Contains("9");
        //Console.WriteLine(res);
        //    string res = "";
        //    string f = "", l = "";
        //    string s = "jay hind jay maharashtra";
        //   string[] words= s.Split(" ");
        //    foreach (string word in words)
        //    {
        //        var n=word.Length - 1;
        //        f= word.Substring(0,n).ToLower();

        //        l= word.Substring(n).ToUpper();
        //        //Console.WriteLine(f+l);
        //        res = res + f + l + " ";
        //    }
        //    Console.WriteLine(res);

        //}




        //======================================================================================================================================
        //======================================================================================================================================
        //Homework
        //11/03/2026


        //public class Programm
        //{
        //    public static void Main(string[] args)
        //    {


        //        //reverse string
        //        string name = "Maithili";
        //        string reverse = "";
        //        for(int i=name.Length-1; i>=0; i--)
        //        {
        //            reverse += name[i];
        //        }

        //        Console.WriteLine(reverse);


        //    }
        //}

        //Write a C# program to find the length of a string.
        //Console.WriteLine("Enter any string ");
        //string s=Console.ReadLine();
        //Console.WriteLine("length od string is "+ s.Length);




        //Write a C# program to concatenate two strings.
        //string s1 = "Hello";
        //string s2 = "Pooja";
        //Console.WriteLine(s1+" "+s2);



        //Write a C# program to compare two strings.
        //string s1 = "Maithili";
        //string s2 = "maithili";
        //string s3 = "Pooja";
        //Console.WriteLine(s1.Equals(s2));
        //Console.WriteLine(s2.Equals(s2,StringComparison.OrdinalIgnoreCase));
        //Console.WriteLine(String.Compare(s1, s2));
        //Console.WriteLine(String.CompareOrdinal(s1, s2));
        //Console.WriteLine(String.CompareOrdinal(s3, s2));



        //Write a C# program to convert lowercase string to uppercase.
        //String str = "hello pooja...!!";
        //Console.WriteLine(str.ToUpper());
        //Console.WriteLine(str);
        //str=str.ToUpper();
        //Console.WriteLine(str);



        //Write a C program to convert uppercase string to lowercase.
        // String str = "Hello Pooja...!!";
        //Console.WriteLine(str.ToLower());
        //Console.WriteLine(str);
        //str = str.ToLower();
        //Console.WriteLine(str);


        //Write a C program to find total number of alphabets, digits or special character in a string.
        //Write a C program to count total number of vowels and consonants in a string.


        //Write a C program to find reverse of a string.
        //string name = "Pooja";
        //char []str =name.ToCharArray();
        //int j = str.Length - 1;
        //for(int i=0; i<str.Length; i++)
        //{
        //    if(i>=j)
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        char temp=str[i];
        //        str[i]=str[j];
        //        str[j]=temp;

        //        j--;
        //    }

        //}
        //string reverse=new string(str);
        //Console.WriteLine(reverse);

        //string str = "Maithili";
        //string reverse = "";
        //for(int i=str.Length-1; i>=0; i--)
        //{
        //    reverse += str[i];
        //}

        //string str = "Pooja";
        //var result=str.ToCharArray().Reverse().ToArray();
        //string reverse = new string(result);
        //Console.WriteLine(reverse);



        //Write a C program to check whether a string is palindrome or not.
        //string s1 = "naman";
        //string reverse=new string (s1.ToCharArray().Reverse().ToArray());
        //if(s1==reverse)
        //{
        //    Console.WriteLine("Palindrome");
        //}
        //else
        //{
        //    Console.WriteLine("Not Palindrome");
        //}



        //Write a C program to find first occurrence of a character in a given string.
        //int index = -1;
        //string str = "Maithili ";
        //Console.WriteLine("Enter char to find in string :");
        //char c = Console.ReadLine()[0];
        //for (int i = 0; i < str.Length; i++)
        //{
        //    if (str[i] == c)
        //    {
        //        index = i;
        //        break;
        //    }
        //}
        //Console.WriteLine(index);
        //==========
        //Console.WriteLine(str.IndexOf(c));




        //Write a C program to find last occurrence of a character in a given string.
        //Console.WriteLine("Enter string :");
        //string str=Console.ReadLine();
        //Console.WriteLine("Enter character to find Last Occurrences of char:");
        //char c=Convert.ToChar(Console.ReadLine());
        //Console.WriteLine(str.LastIndexOf(c));


        //Write a C program to replace first occurrence of a character with another in a string.
        //Console.WriteLine("Enter any string :");
        //string str=Console.ReadLine();
        //var str1=str.ToArray();
        //Console.WriteLine("Enter char to find in string :");
        //char c=Convert.ToChar(Console.ReadLine());
        //for(int i=0;i<str1.Length;i++)
        //{
        //    if(str[i] == c)
        //    {
        //        Console.WriteLine("Enter char to replace :");
        //        char rc = Convert.ToChar(Console.ReadLine());
        //        str1[i] = rc;
        //        break;
        //    }

        //}
        //Console.WriteLine(new string(str1));




        //Write a C# program to replace last occurrence of a character with another in a string.
        //Console.WriteLine("Enter any string :");
        //string str = Console.ReadLine();

        //var str1 = str.ToArray();

        //Console.WriteLine("Enter char to find in string :");
        //char c = Convert.ToChar(Console.ReadLine());

        //for (int i = 0; i < str1.Length; i++)
        //{
        //    if (str[i] == c)
        //    {
        //        Console.WriteLine("Enter char to replace :");
        //        char rc = Convert.ToChar(Console.ReadLine());
        //        str1[i] = rc;
        //        break;
        //    }

        //}
        //Console.WriteLine(new string(str1));





        //Write a C# program to toggle case of each character of a string.


          
        


    }



}
