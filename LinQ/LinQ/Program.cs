using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LINQ;

public class Program
{

    public static void Main(string[] args)
    {
        //Class work
        //16-01-2026


        //int[] elements = { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };
        //int[] ages = { 22, 23, 24, 67, 17, 25, 26, 27, 11, 22, 11, 33, 22, 33, 22, 22, 22 };
        //var result = elements.Where(e => e > 10 && e % 2 == 0).Select(s => new { num = s, square = s * s }).ToArray();
        //foreach(var obj in result)
        //{
        //    Console.WriteLine($"number ={obj.num} Square ={obj.square}");
        //}



        //what is diff between First and FirstOrDefault
        // First will throw exception if no element found
        // FirstOrDefault will return default value if no element found
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 6, 23, 55, 77, 90 };

        //First
        //int element = arr.First(e => e > 90);
        //exception occurs because no value which is greater than 90

        //FirstOrDefault
        //int element = arr.FirstOrDefault(e => e > 90);//0
        //Console.WriteLine(element);
        //int element1 = arr.FirstOrDefault(e => e < 70);
        //Console.WriteLine(element1);








        //Homework
        //16-01-2026


        //Given an integer array, find the first element using LINQ.
        //int[] num = { 1, 2, 3, 3, 4, 56, 7, 88 };
        //int ele = num.First();
        //Console.WriteLine("First Elemt in array :" + ele);


        //Given an empty integer array, retrieve the first element safely without exception.
        //int[] num = { };
        //int ele = num.FirstOrDefault();
        //Console.WriteLine(ele);


        //Given a string array, get the last element using LINQ.
        //string[] names = { "Maithili", "Shivtej", "Aryan", "Gayatri", "Vaishnavi" };
        //string lastName = names.Last();
        //Console.WriteLine("Last name in array : " + lastName);


        //Given an array with exactly one element, retrieve it using Single().
        //int[] num = { 1 };
        //int singleElement = num.Single();
        //Console.WriteLine("Single element = " + singleElement);


        //From an integer array, select only even numbers.
        //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 1, 4, 15, 75, 43, 12 };
        //int[] result = num.Where(e => e % 2 == 0).ToArray();
        //foreach(int e in result)
        //{
        //    Console.Write(e + "  ");
        //}


        //🔵 Intermediate

        //From an integer array, find all numbers greater than 50.
        //int[] nums = { 43, 76, 32, 3, 86, 32, 11, 2, 56, 43, 21, 57, 102, 405, 500 };
        //int[] result = nums.Where(n => n > 50).ToArray();
        //foreach(int n in result)
        //{
        //    Console.Write(n + "  ");
        //}


        //Given an integer array, return a new array containing the square of each element.
        //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] result =nums.Select(e => e* e).ToArray();
        //foreach(int n in result)
        //{
        //    Console.Write(n + " ");
        //}

        //Sort an integer array in ascending order.
        //int[] nums = { 2, 34, 23, 5, 7, 21, 7, 21 };
        //int[] result = nums.Order().ToArray();
        //int[] result = nums.OrderBy(e=>e).ToArray();
        //foreach (int n in result)
        //{
        //    Console.Write(n + "  ");
        //}


        //Sort an integer array in descending order.
        //int[] nums = { 65, 24, 29, 23, 68, 1, 2, 3, 4, 4, 0 };
        //int[] result = nums.OrderByDescending(e=>e).ToArray();
        //foreach(int n in result)
        //{
        //    Console.Write(n + " ");
        //}


        //From an integer array, find the first number greater than 40.
        //int[] nums = { 1, 2, 54, 23, 78, 21, 54, 87, 41, 34 };
        //int element = nums.FirstOrDefault(e => e > 40);
        //Console.WriteLine("Fiest element greater than 40 :" + element);
        //int element = nums.LastOrDefault(e => e > 40);
        //Console.WriteLine("Last element greater than 40 :" + element);


        //Filter numbers greater than a given value and convert the result to an array.
        //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 312, 43, 56, 76, 67, 32, 32, 45, 67 };
        //int[] result = nums.Where(e => e > 40).ToArray();
        //foreach(int n in result)
        //{
        //    Console.Write(n + " ");
        //}


        //🔴 Advanced
        //Group an integer array into Even and Odd numbers.
        ////Count how many elements exist in each group after grouping.
        //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 22, 44, 66, 88, 32, 98, 33, 51 };
        //var evenOdd = nums.GroupBy(n => n % 2 == 0);
        //foreach (var group in evenOdd)
        //{
        //    Console.WriteLine(group.Key ? "\n Even number }" : "\n Odd number");
        //    Console.WriteLine($" Count of element :{group.Count()}");
        //    foreach (var n in group)
        //    {
        //        Console.Write(n + " ");
        //    }
        //}




        //foreach (var group in evenOdd)
        //{
        //    int count = 0;
        //    foreach (var n in group)
        //    {
        //        count++;
        //    }
        //    Console.Write(group.Key ? "\n Even number :" : "\n Odd number :");
        //    Console.Write(count);

        //} instead of this use dirctly count method


        //Using an integer array, retrieve a value using SingleOrDefault() safely.
        //int[] num = {1,1,2,3,5,4,12,88};
        //int singleElement = num.SingleOrDefault(e=>e>20);
        //Console.WriteLine(singleElement);



        //From an empty array, safely retrieve:
        //int[] num = { };
        ////first element
        //int ele = num.FirstOrDefault();
        //Console.WriteLine(ele);
        ////last element
        //int lastElement = num.LastOrDefault();
        //Console.WriteLine(lastElement);
        ////single element
        //int singleElement = num.SingleOrDefault();
        //Console.WriteLine(singleElement);


        //------------------------------------------------------------------------------------------------------------------------------------

        //17-01-2026

        //Homework Work


        //1.Create an integer array of 10 elements and print all elements.
        //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //foreach(int n in num)
        //{
        //    Console.Write(n + "  ");
        //}


        //2.Find the sum of all elements in an integer array.
        //int[] nums = { 1, 21, 26, 25, 12, 11, 23, 5, 7,16,18};
        //int sum = nums.Sum();
        //Console.WriteLine("Sum of all elements in array is :"+sum);


        //3.Find the maximum and minimum value from an array.
        //int[] nums = { 1, 21, 26, 25, 12, 11, 23, 5, 7, 16, 18 };
        //int max = nums.Max();
        //Console.WriteLine("Max element in array is :" + max);
        //int min = nums.Min();
        //Console.WriteLine("Min element in array is :" + min);


        //4.Count how many even and odd numbers are present in an array.
        //int[] nums = { 1, 21, 26, 25, 12, 11, 23, 5, 7, 16, 18 };
        //var evenOdd = nums.GroupBy(n => n % 2 == 0);
        //foreach(var group in evenOdd)
        //{
        //    string groupName = (group.Key) ? "Even" : "Odd";
        //    Console.WriteLine($"{groupName} count : {group.Count()}");
        //}


        //5.Reverse an array without using built-in reverse methods.
        //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int j = nums.Length - 1;
        //for (int i = 0; i <= j; i++)
        //{
        //    if (j <= i)
        //    {
        //        break;
        //    }
        //    int temp = nums[i];
        //    nums[i] = nums[j];
        //    nums[j] = temp;
        //    j--;
        //}
        //foreach (int n in nums)
        //{
        //    Console.Write(n + " ");
        //}



        //6.Sort an array in ascending order.
        //int[] nums = { 1, 21, 26, 25, 12, 11, 23, 5, 7, 16, 18 };
        //var result=nums.Order();
        //foreach(int n in result)
        //{
        //    Console.Write(n+" ");
        //}


        //7.Search for a given element in an array and print its index.
        //int[] nums = { 1, 21, 26, 25, 12,1,25,26, 11, 23, 5, 7, 16, 18 };
        //int element = 25;
        //int index = -1;
        //for(int i=0;i<arr.Length;i++)
        //{
        //    if (nums[i]==element)
        //    {
        //        index = i;
        //        break;
        //    }
        //    index = -1;
        //}
        //Console.WriteLine("Index Of target elememt is :" + index);



        //8.Remove duplicate elements from an array.
        //int[] nums = { 1, 21, 26, 25, 12,1,25,26, 11, 23, 5, 7, 16, 18 };
        //var result=nums.Distinct();
        //foreach(var n in result)
        //{
        //    Console.Write(n + " ");
        //}


        //9.Find the second largest number in an array.
        //int[] nums = { 1, 21, 26, 25, 12, 11, 23, 5, 7, 16, 18 };
        //int element = nums.OrderByDescending(n => n).Skip(1).First();
        //Console.WriteLine("Second Largest element in array is :" + element);


        //10.Merge two arrays into a single array.
        //int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] nums2 = { 1, 21, 26, 25, 12, 11, 23, 5, 7, 16, 18 };
        //int length = nums1.Length + nums2.Length;
        //int[] result = new int[length];
        //int j = 0;
        //foreach(int n in nums1)
        //{
        //    result[j] = n;
        //    j++;
        //}
        //foreach (int n in nums2)
        //{
        //    result[j] = n;
        //    j++;
        //}
        //foreach(int n in result)
        //{
        //    Console.Write(n + " ");
        //}



        //11.Use LINQ to find all even numbers from an integer array.
        //int[] nums= { 1, 21, 26, 25, 12, 11, 23, 5, 7, 16, 18 };
        //int[] even = nums.Where(n => n % 2 == 0).ToArray();
        //foreach(int n in even)
        //{
        //    Console.Write(n + " ");
        //}



        //12.Use LINQ to find all numbers greater than 50 from an array.
        //int[] nums = { 1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 };
        //int[] result = nums.Where(n => n > 50).ToArray();
        //foreach(int n in result)
        //{
        //    Console.Write(n+" ");
        //}


        //13.Use LINQ to calculate the sum and average of array elements.
        //int[] nums = { 1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 };
        //var sum = nums.Sum();
        //var Average = nums.Average();
        //Console.WriteLine($"Sum of all elements in array : {sum} \nAvergae of all element in array :{Average}");


        //14.Find the maximum and minimum value using LINQ.
        //int[] nums = { 1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 };
        //Console.WriteLine("Max element in array is " + nums.Max());
        //Console.WriteLine("Max element in array is " + nums.Min());


        //15.Sort an array in descending order using LINQ.
        //int[] nums = { 1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 };
        //var result = nums.OrderByDescending(n => n);
        //foreach(int n in result)
        //{
        //    Console.Write(n + " ");
        //}


        //16.Remove duplicate elements using LINQ.
        //int[] nums = { 1, 23, 55, 99, 2, 22, 44, 55, 75, 22, 25, 99, };
        //var result = nums.Distinct().ToArray();
        //foreach(var n in result)
        //{
        //    Console.Write(n + " ");
        //}



        //17.Find the top 3 largest numbers using LINQ.
        //int[] nums = { 1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 };
        //var element = nums.OrderByDescending(n => n).Skip(2).FirstOrDefault();
        //Console.WriteLine("Third largest element in array :" + element);


        //18.Count how many elements are greater than the average value.
        //int[] nums = { 1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 };
        //var count = nums.Count(n => n > nums.Average());
        //Console.WriteLine("no of element which is greater then average :" + count);


        //19.Convert an array of strings into uppercase using LINQ.
        //string[] names = { "maithili", "shivtej", "aryan", "gayatri", "vaishnavi" };
        //var result = names.Select(n => n.ToUpper());
        //foreach( var n in result)
        //{
        //    Console.Write(n + " ");
        //}


        //20.Group numbers by even and odd using LINQ.
        //int[] nums = { 1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 };
        //var count = nums.GroupBy(n => n % 2 == 0).Count();
        //Console.WriteLine("Count of group is :" + count);



        //21.Given an array of integers, use LINQ to find the first number greater than 100. If none exists, return -1.
        //int[] nums = {1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 ,104};
        //var element = nums.Where(n => n > 100).FirstOrDefault(-1);
        //Console.WriteLine(" first number greater than 100 in given array is :" + element);


        //22.Find all numbers that are divisible by both 3 and 5.
        //int[] nums = {1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 ,104};
        //var result = nums.Where(x => x % 3 == 0 && x % 5 == 0).ToArray();
        //foreach (var n in result)
        //{
        //    Console.Write(n);
        //}


        //23.Find the count of prime numbers in an array using LINQ.
        //int[] nums = {1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 ,104};
        //var element=nums.Where(n=>)


        //24.Find the second smallest number using LINQ.
        //int[] nums = {1, 32, 46, 23, 65, 89, 2, 22, 44, 55, 75, 12, 25, 99, 51, 17 ,104};
        //int element = nums.Order().Skip(1).FirstOrDefault();
        //Console.WriteLine("second smallest number : " + element);



        //25.Find all distinct characters from a string using LINQ.
        //string name = "maithili";
        //var element = name.Distinct().ToArray();
        //foreach(var n in element)
        //{
        //    Console.Write(n + " ");
        //}


        //26.Find the longest string in a string array.
        //string[] names = { "maithili", "shivtej", "aryan", "gayatri", "vaishnavi" };
        //var result = names.OrderBy(n => n.Length).LastOrDefault();
        //Console.WriteLine("longest string in a string array is :" + result);


        ////27.Find words that start with a vowel using LINQ.
        //string[] names = { "Maithili", "Shivtej", "Aryan", "Gayatri", "Vaishnavi", "Sanket", "Aniket" };
        //var result = names.Where(n => n.First() == 'A' || n.First() == 'E' || n.First() == 'I' || n.First() == 'O' || n.First() == 'U').ToArray();
        //foreach (var n in result)
        //{
        //    Console.Write(n + "  ");
        //}


        //28.Check if all elements are positive using LINQ.
        //int[] nums = {1, 32, 46, 23,-4,-7, 2, 22,12, 25, 99, 51, 17 };
        //var result = nums.All(n => n > 0);
        //Console.WriteLine("are all elements positive =" + result);


        //29.Check if any number is negative using LINQ.
        //int[] nums = {1, 32, 46, 23,-4,-7, 2, 22,12, 25, 99, 51, 17 };
        //var result = nums.Any(n => n < 0);
        //Console.WriteLine("is any number nagative in given array :" + result);


        //30.Create a dictionary from an array using LINQ.
        //int[] nums = { 1,  2, 3,4,5,6,7,8,9 };
        //var result = nums.ToDictionary(x => x, x => x * x * x);
        //foreach(var n in result)
        //{
        //    Console.WriteLine($"{n.Key} => {n.Value}");
        //}


        //31.Group numbers by their digit count using LINQ.
        //int[] nums = { 1, 2, 3, 4, 6, 7, 8, 9, 4, 2, 6, 8, 3, 1, 7 };
        //var group = nums.GroupBy(n => n);
        //foreach(var n in group)
        //{
        //    Console.WriteLine(n.Key + ": " + n.Count());
        //}


    }

}

