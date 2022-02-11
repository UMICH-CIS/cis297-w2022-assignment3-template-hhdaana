using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class CheckingAccount : Account
    {
        private decimal fee;

        public CheckingAccount(decimal balance, decimal f) : base(balance)
        {
            fee = f;
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance = Balance - fee;
        }

        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                Balance = Balance - fee;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
