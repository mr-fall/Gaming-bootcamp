using System;
using System.Collections.Generic;

namespace ATMApp
{
    public class Account
    {
        public string AccountNumber { get; private set; }
        public int PIN { get; private set; }
        public double Balance { get; private set; }
        public List<string> Transactions { get; private set; }

        public Account(string accountNumber, int pin, double balance)
        {
            AccountNumber = accountNumber;
            PIN = pin;
            Balance = balance;
            Transactions = new List<string>();
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Ch7al 3andk f l compte: ${Balance:F2}");
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Dépôt khasso ykoun positif, 7awl marra okhra!");
                return;
            }
            Balance += amount;
            Transactions.Add($"Dépôt: ${amount:F2}");
            Console.WriteLine($"Mabrouk! Rak zadt ${amount:F2}. L balance daba: ${Balance:F2}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Retrait khasso ykoun positif!");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Ma 3andkch lflouss kifach tdir retrait!");
                return;
            }

            Balance -= amount;
            Transactions.Add($"Retrait: ${amount:F2}");
            Console.WriteLine($"Retrait tssala b najah! L balance daba: ${Balance:F2}");
        }

        public void ShowTransactions()
        {
            Console.WriteLine("\nTarikh dyal transactions:");
            if (Transactions.Count == 0)
            {
                Console.WriteLine("Ma kaynach transactions daba.");
                return;
            }

            foreach (var t in Transactions)
            {
                Console.WriteLine(t);
            }
        }
    }
}
