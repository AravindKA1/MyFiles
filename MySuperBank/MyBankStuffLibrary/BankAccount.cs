using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankyStuffLibrary
{
    public class BankAccount
    {
        public string Number { get; }
        public string owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in AllTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }
        private static int AccountNumber = 1234567890;
        private List<Transaction> AllTransactions = new List<Transaction>();

        public BankAccount(String Name, decimal InitialBalance)
        {
            this.owner = Name;
            MakeDeposit(InitialBalance, DateTime.Now, "Initial balance");
            this.Number = AccountNumber.ToString();
            AccountNumber++;

        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);

            AllTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            AllTransactions.Add(withdrawal);
        }
        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            // report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in AllTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return report.ToString();
        }
    }
}






