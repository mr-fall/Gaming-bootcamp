using System;
using System.Collections.Generic;

namespace ATMApp
{
    class Program
    {
        static void Main()
        {
            var accounts = new Dictionary<string, Account>
            {
                { "12345", new Account("12345", 1111, 1000) },
                { "67890", new Account("67890", 2222, 2000) },
                { "54321", new Account("54321", 3333, 500) }
            };

            ATM atm = new ATM(accounts);

            Console.WriteLine("Marhba bik f ATM Machine!");

            Account currentAccount = atm.Authenticate();
            if (currentAccount == null)
                return;

            bool continueRunning = true;
            while (continueRunning)
            {
                atm.ShowMenu();
                Console.Write("Chno bghiti dir? (ktab numéro): ");
                string choice = Console.ReadLine();
                continueRunning = atm.PerformAction(currentAccount, choice);
            }

            Console.WriteLine("\nChokran 3la ist3mal dyalk l ATM. Hadi hiya summary dyal transactions dyalk:");
            currentAccount.ShowTransactions();
        }
    }
}
