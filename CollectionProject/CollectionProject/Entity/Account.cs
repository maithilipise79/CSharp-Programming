using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public  class Account
    {
        public int AccountNo { get; set; }
        public string BankName {  get; set; }
        public string AccHolderName {  get; set; }
        public double Balance {  get; set; }

        public Account() { }
        public Account(int accountNo, string bankName, string accHolderName, double balance )
        {
            AccountNo = accountNo;
            BankName = bankName;
            AccHolderName = accHolderName;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"Account No :{AccountNo} , Bank Name :{BankName} , Account Holder Name :{AccHolderName} , Balance :{Balance} ";
        }
    }
}
