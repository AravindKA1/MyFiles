using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBankyStuffLibrary;
namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Aravind", 10000);
            Console.WriteLine($"Account {account.Number} is created for {account.owner} with balance {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Gold");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(1000, DateTime.Now, "Deposit");
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());

        }
    }
}


