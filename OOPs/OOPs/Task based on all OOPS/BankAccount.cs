using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    internal class BankAccount
    {
        private long accountNumber;
        private double balance;

        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        private void Deposite(double amount)
        {
            balance = balance + amount;
            Console.WriteLine($"Avl Balance : {balance}");

        }
        private void Withdraw(double amount)
        {
            if(balance>=amount)
            {
                balance = balance - amount;
                Console.WriteLine($"{amount} is succesfull withdraw");
                Console.WriteLine($"Avl Balance : {balance}");

            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        private  void GetBalance ()
        {
            Console.WriteLine($"Avl Balance : {balance}");
        }

        public void BankService()
        {
            char ans;
            do
            {
               
                Console.WriteLine("Enter your Account Number :");
                long UserAccountNumber = long.Parse(Console.ReadLine());
                if (UserAccountNumber == accountNumber)
                {
                    Console.WriteLine("Enter Your Choice :\n1.Deposite Amount \n2. Withdraw Amount \n3. Get Balance");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter amount for the  Deposite");
                            double amountD = Convert.ToDouble(Console.ReadLine());
                            Deposite(amountD);
                            break;

                        case 2:
                            Console.WriteLine("Enter amount for the  Withdraw");
                            double amountW = Convert.ToDouble(Console.ReadLine());
                            Withdraw(amountW);
                            break;

                        case 3:
                            GetBalance();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Account Number is Wrong");
                }

                Console.WriteLine("Do you want another service if Yes then enter yes :");
                ans = Console.ReadLine()[0];

            } while (ans == 'y' || ans == 'Y');
        }
    }
}
