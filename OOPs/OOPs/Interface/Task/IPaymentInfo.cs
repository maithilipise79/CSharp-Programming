using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Interface.Task
{
    //18/02/2026
    //factory pattern
    public interface IPaymentInfo
    {
        void Pay();
    }

    public class UPI :IPaymentInfo
    { 
        public void Pay()
        {
            Console.WriteLine("Payment done by UPI");
        }
    }

    public class DebitCard: IPaymentInfo 
    {
        public void Pay()
        {
            Console.WriteLine("Payment done by Debit Card");
        }
    }

    public class CreditCard : IPaymentInfo 
    {
        public void Pay()
        {
            Console.WriteLine("Payment done by Credit Card");
        }
    }

    public class PaymentFactory
    { 
        public static IPaymentInfo GetPayment(string type)
        {
            if(type.ToLower().Contains("Credit"))
            {
                return new CreditCard();
            }
            else if(type.ToLower().Contains("Debit"))
            {
                return new DebitCard();
            }
            else      
            {
                return new UPI();
            }

        }
    }

}
