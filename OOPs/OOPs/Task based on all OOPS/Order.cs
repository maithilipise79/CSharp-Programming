using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    public class Order
    {
        public int OrderID {  get; set; }
        public double Amount {  get; set; }
    }

    public interface IPayment
    {
        public  void Pay(double amount);
    }

    public class CreditCardPayment: IPayment
    { 
        public int CreditCardNo {  get; set; }

        public void Pay(double amount)
        {
            Console.WriteLine("Enter you Credit Card Pin :");
            int pin=Convert.ToInt32(Console.ReadLine());
            if(pin==CreditCardNo)
            {
                Console.WriteLine($"Payment of {amount}.rs is Done");
            }
            else
            {
                Console.WriteLine("Credit card Pin is incorrect");
            }

        }
    }
    public class UPIPayment : IPayment
    {
        public int UPIID { get; set; }

        public void Pay(double amount)
        {
            Console.WriteLine("Enter you UPI ID :");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id == UPIID)
            {
                Console.WriteLine($"Payment of {amount}.rs is Done");
            }
            else
            {
                Console.WriteLine("UPI ID is incorrect");
            }

        }

    }
    public class PayPalPayment: IPayment
    {

        public int PayPalID { get; set; }

        public void Pay(double amount)
        {
            Console.WriteLine("Enter you PayPal ID :");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id == PayPalID)
            {
                Console.WriteLine($"Payment of {amount}.rs is Done");
            }
            else
            {
                Console.WriteLine("PayPal ID is incorrect");
            }

        }
    }

    public class OrderService
    {
       

        public IPayment payment;
        public Order order;
        public OrderService(IPayment p,Order order)
        {
            payment = p;
            this.order= order;
        }


        public bool ProcessOrder()
        {
            payment.Pay(order.Amount);
            return true;
        }

    }

    public class InvoiceGenerator
    { 
        private readonly OrderService orderService;
        public InvoiceGenerator(OrderService orderService)
        {
            this.orderService = orderService;
        }
        public void Generator()
        {
            
                Console.WriteLine($"-----------  Invoice  ----------");
                Console.WriteLine($"Order ID       :{orderService.order.OrderID}");
                Console.WriteLine($"Order Amount   :{orderService.order.Amount}");
                Console.WriteLine($"Payment Status : Done ");

           
        }


    }

    public class Factory
    { 

        public void PaymentCounter(Order order)
        {
            Console.WriteLine("Enter you choice to complete payment :\n1.Credit Card\n2.UPI ID \n3.PayPal");
            int choice = Convert.ToInt32(Console.ReadLine());
            IPayment p;
            switch (choice)
            {
                case 1:
                    p= new CreditCardPayment { CreditCardNo = 2442 };
                    break;
                case 2:
                     p = new UPIPayment { UPIID = 4007 };
                    break;
                case 3:
                    p= new PayPalPayment{ PayPalID = 12345 };
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }
            OrderService obj = new OrderService(p , order);
            obj.ProcessOrder();
            InvoiceGenerator obj2= new InvoiceGenerator(obj);
            obj2.Generator();
        }

    }




}
