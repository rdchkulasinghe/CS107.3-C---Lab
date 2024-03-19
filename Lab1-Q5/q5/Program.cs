using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            for(int i=0;i<12;i++)
            {
                Console.WriteLine(number + " x " + i + " = " + number * i);
            }
        }
    }
}
