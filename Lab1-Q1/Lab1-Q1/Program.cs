using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q1
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the lenght");
                int lenght = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the width");
                int width = int.Parse(Console.ReadLine());

                int area = Area(lenght, width);

                Console.WriteLine("The area is :" + area);
            }
            static int Area(int lenght, int width)
            {
                return lenght * width;
            }
        }

}
