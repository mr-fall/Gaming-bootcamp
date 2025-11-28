using System;
using System.Collections.Generic;

namespace ATMApp
{
    public class ATM
    {
        private Dictionary<string, Account> Accounts;

        public ATM(Dictionary<string, Account> accounts)
        {
            Accounts = accounts;
        }

        public Account Authenticate()
        {
            Console.Write("Ktab numéro dyal compte: ");
            string accNumber = Console.ReadLine();

            if (!Accounts.ContainsKey(accNumber))
            {
                Console.WriteLine("Ma l9itx compte hada.");
                return null;
            }

            int attempts = 0;
            while (attempts < 3)
            {
                Console.Write("Ktab PIN dyalk: ");
                if (int.TryParse(Console.ReadLine(), out int pin))
                {
                    if (Accounts[accNumber].PIN == pin)
                    {
                        Console.WriteLine("Tchkoun Hada!\n");
                        return Accounts[accNumber];
                    }
                    else
                    {
                        Console.WriteLine("PIN ghalat. 7awl marra okhra.");
                        attempts++;
                    }
                }
                else
                {
                    Console.WriteLine("Input ghalat. Ktib ghir numbers.");
                }
            }

            Console.WriteLine("Drt bzaf dyal tries ghalat. Exit ...");
            return null;
        }

        public void ShowMenu()
        {
            Console.WriteLine("\nMenu dyal ATM:");
            Console.WriteLine("1. Chouf balance");
            Console.WriteLine("2. Zid Flouss");
            Console.WriteLine("3. Srah Flouss");
            Console.WriteLine("4. Chouf transactions");
            Console.WriteLine("5. Khrej");
        }

        public bool PerformAction(Account account, string choice)
        {
            switch (choice)
            {
                case "1":
                    account.CheckBalance();
                    break;
                case "2":
                    Console.Write("Ktab l montant li bghiti tzed: ");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        account.Deposit(depositAmount);
                    else
                        Console.WriteLine("Montant ghalat.");
                    break;
                case "3":
                    Console.Write("Ktab l montant li bghiti tsrah: ");
                    if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        account.Withdraw(withdrawAmount);
                    else
                        Console.WriteLine("Montant ghalat.");
                    break;
                case "4":
                    account.ShowTransactions();
                    break;
                case "5":
                    Console.WriteLine("Kharjt mn ATM...");
                    return false;
                default:
                    Console.WriteLine("Option ghalat. 7awl marra okhra.");
                    break;
            }

            return true;
        }
    }
}
