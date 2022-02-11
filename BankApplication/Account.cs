using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        private decimal balance;
        
        //Account constructor
        public Account(decimal b)
        {
            balance = b;
            if (b < 0)
                throw new ArgumentException(String.Format("Initial balance can't be less than 0"));
        }

        public virtual bool Debit(decimal amount)
        {
            // checkick balnce to be more than or equal to the ammount
            if (balance >= amount)
            {
                balance = balance - amount;
                return true;
            }
            else
            {
                Console.WriteLine("Debit amount exceeded account balance");
                return false;
            }
        }

        // Deposit funds
        public virtual void Credit(decimal amount)
        {
            if(amount >= 0)
                balance = amount + balance;
            else
                Console.WriteLine("You can't desposit negative values");
        }

        public decimal Balance
        {
            get 
            {
                if (balance >= 0)
                { 
                    return balance;
                }
                else {
                    Console.WriteLine("Balance is less than 0");
                    return balance;
                }   
            }

            set
            {
                if (value >= 0.0M) 
                {
                    balance = value;
                }
                else
                {
                    balance = 0.0M;
                    Console.WriteLine("Can't set balance to a negative value");
                }
            }
        }
    }
}
