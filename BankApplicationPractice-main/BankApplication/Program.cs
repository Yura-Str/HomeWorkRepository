﻿using System;
using BankLibrary;

namespace BankApplication
{
    class Program
    {
        private static Bank<Account> _bank1 = new Bank<Account>();
        
        static void Main(string[] args)
        {
            bool alive = true;
            while (alive)
            {
                Console.Clear();
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1. Open Account \t 2. Withdraw sum \t 3. Add sum");
                Console.WriteLine("4. Close Account \t 5. Skip day \t 6. Exit program");
                Console.WriteLine("Enter the item number:");
                Console.ForegroundColor = color;
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            OpenAccount();
                            break;
                        case 2:
                            Withdraw();
                            break;
                        case 3:
                            Put();
                            break;
                        case 4:
                            CloseAccount();
                            break;
                        case 5:
                            break;
                        case 6:
                            alive = false;
                            continue;
                    }
                    // CalculatePercentage
                }
                catch (Exception ex)
                {
                    color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = color;
                }
            }
        }

        private static void GetLockerData()
        {
            Console.WriteLine("Specify ID");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter keyword:");
            string keyword = Console.ReadLine();

            var data1 = (int)_bank1.GetLockerData(id, keyword);
            int data2 = _bank1.GetLockerData<int>(id + 2, keyword);
            string data3 = _bank1.GetLockerData<string>(id + 1, keyword);
        }
        
        private static void OpenAccount()
        {
            Console.WriteLine("Specify the sum to create an account: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Select an account type: \n 1. On-Demand \n 2. Deposit");
            var type = Enum.Parse<AccountType>(Console.ReadLine()!);
            
            _bank1.OpenAccount(new OpenAccountParameters
            {
                Amount = sum,
                Type = type,
                AccountCreated = NotifyAccountCreated
            });
        }

        private static void Withdraw()
        {
            Console.WriteLine("Specify the sum to withdraw from the account: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter account id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            // Withdraw;
        }

        private static void Put()
        {
            Console.WriteLine("Specify the sum to put on the account: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter account id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            // Put
        }
        
        private static void CloseAccount()
        {
            Console.WriteLine("Enter the account id to close: ");
            int id = Convert.ToInt32(Console.ReadLine());

            // Close
        }

        private static void NotifyAccountCreated(string message)
        {
            Console.WriteLine(message);
        }
    }
}
