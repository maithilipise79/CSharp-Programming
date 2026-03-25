using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.AdvancedLevelProblem
{
    //public class Payment
    //{
       
    //    //11)Create a Payment class with overloaded Pay() methods for: (Cash, Card, UPI)
    //    public double InitialAmount {  get; set; }
    //    public int CardId {  get; set; }
    //    public string UPI {  get; set; }
    //    public Payment(double amount, int cardId, string uPI)
    //    {
    //        InitialAmount = amount;
    //        CardId = cardId;
    //        UPI = uPI;
    //    }
    //    public void Pay(double amount)
    //    {
    //        if(amount<=InitialAmount)
    //        {
    //            Console.WriteLine("Payment is done by Cash");
    //            InitialAmount = InitialAmount - amount;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Not sufficient Balance");
    //        }
            
    //    }
    //    public void Pay(double amount,int cardNo)
    //    {
    //        if(CardId==cardNo)
    //        {
    //            if (amount <= InitialAmount)
    //            {
    //                Console.WriteLine("Payment is done by Card");
    //                InitialAmount = InitialAmount - amount;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Not sufficient Balance");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Incorrect Card ID");
    //        }
            
    //    }
    //    public void Pay(int amount,string upi)
    //    {

    //        if (UPI == upi)
    //        {
    //            if (amount <= InitialAmount)
    //            {
    //                Console.WriteLine("Payment is done by UPI");
    //                InitialAmount = InitialAmount - amount;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Not sufficient Balance");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Incorrect UPI ID");
    //        }

    //  }
   // }
}
