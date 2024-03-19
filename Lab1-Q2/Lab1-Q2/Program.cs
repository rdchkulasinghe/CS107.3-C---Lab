using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q2
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) ;
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }
    }
}
