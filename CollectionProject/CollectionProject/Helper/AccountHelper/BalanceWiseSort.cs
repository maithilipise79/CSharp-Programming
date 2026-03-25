using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionProject.Entity;

namespace CollectionProject.Helper.AccountHelper
{
    public class BalanceWiseSort : IComparer<Account>
    {
        public int Compare(Account? x, Account? y)
        {
            return x.Balance.CompareTo(y.Balance);
        }
    }
}
