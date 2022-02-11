using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Account[] accounts = new Account[4];

            accounts[0] = new SavingsAccount(30M, .03M);
            accounts[1] = new CheckingAccount(80M, 1M);
            accounts[2] = new SavingsAccount(200M, .015M);
            accounts[3] = new CheckingAccount(400M, .5M);

            // loop through array, prompting user for debit and credit amounts
            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine($"Account {i + 1} balance: {accounts[i].Balance:C}");

                Console.Write($"\nEnter an amount to withdraw from Account {i + 1}: ");
                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());

                accounts[i].Debit(withdrawalAmount); 

                Console.Write($"\nEnter an amount to deposit into Account {i + 1}: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());

                accounts[i].Credit(depositAmount);

                if (accounts[i] is SavingsAccount)
                {
                    SavingsAccount currentAccount = (SavingsAccount)accounts[i];

                    decimal interestEarned = currentAccount.AddIntrestRate();
                    Console.WriteLine($"Adding {interestEarned:C} interest to Account {i + 1} (a SavingsAccount)");
                    currentAccount.Credit(interestEarned);
                }

                Console.WriteLine($"\nUpdated Account {i + 1} balance: {accounts[i].Balance:C}\n\n");

            }
        }
    }
}
