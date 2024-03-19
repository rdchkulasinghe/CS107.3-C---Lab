using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i <= number; i++)
            {
                int result = Fibo(i);
                Console.WriteLine(result);
            }
        }
        static int Fibo (int i)
        {
            if(i <= 1)
            {
                return i;
            }
            else
            {
                return Fibo(i - 1)+Fibo(i - 2);
            }
  
        }
    }
}
