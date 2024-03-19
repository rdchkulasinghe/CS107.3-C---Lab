using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Q3
{
    class TemperatureTracker
    {
        private double[] dailyTemperatures;
        public TemperatureTracker()
        {
            dailyTemperatures = new double[7]; 
        }

        public void InputTemperatures()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter temperature for day {i + 1}: ");
                double temperature = Convert.ToDouble(Console.ReadLine());
                dailyTemperatures[i] = temperature;
            }
        }

        public void DisplayWeeklyReport()
        {
            Console.WriteLine("Weekly Temperature Report:");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyTemperatures[i]}°C");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();
            tracker.InputTemperatures();
            tracker.DisplayWeeklyReport();

            Console.ReadLine(); 
        }
    }

}
