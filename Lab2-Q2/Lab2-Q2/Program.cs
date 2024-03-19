using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q2
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }
        
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }
       
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount for deposit.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("456912387");

            decimal depositAmount = 100;
            myAccount.Deposit(depositAmount);

            Console.ReadLine(); 
        }
    }

}
