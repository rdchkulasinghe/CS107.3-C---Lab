using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int sum=0;
            if (number > 0)
            {
                for (int i = 0; i <= number; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
            else 
            { 
                Console.WriteLine("Error"); 
            }
        }
    }
}
