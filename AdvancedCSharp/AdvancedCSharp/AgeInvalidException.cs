using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    public  class AgeInvalidException:Exception
    {
        public AgeInvalidException()
        {

        }
        public AgeInvalidException(string massage):base(massage) 
        {

        }

    }

    public class Program
    { 
        public static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("Enter age :");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("Valid ");
                }
                else
                {

                    throw new AgeInvalidException(age + " Age is invalid");

                    //Console.WriteLine("InValid "+age);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            for (int i=0;i<6;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}
