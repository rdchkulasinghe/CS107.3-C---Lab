using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q7
{
    class Program
    {
        static decimal balance = 1000; // Initial balance

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("ATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your balance is: ${balance}");
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: $");
            decimal amount = decimal.Parse(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"${amount} deposited successfully. New balance: ${balance}");
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: $");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"${amount} withdrawn successfully. New balance: ${balance}");
            }
        }
    }
}
