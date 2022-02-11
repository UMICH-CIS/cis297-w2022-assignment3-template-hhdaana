using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class SavingsAccount : Account

    {
        private decimal rate;

        public SavingsAccount(decimal balance, decimal r) : base(balance)
        {
            rate = r;
        }

        public decimal AddIntrestRate()

        {
            return Balance * rate / 100;
        }
    }
}
