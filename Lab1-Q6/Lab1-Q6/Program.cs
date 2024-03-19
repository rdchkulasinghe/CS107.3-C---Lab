using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Q6
{
    class Program
        {
            static void Main()
            {
                Console.Write("Enter student's name: ");
                string name = Console.ReadLine();

                Console.Write("Enter exam marks: ");
                int marks = int.Parse(Console.ReadLine());

                if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("Error: Marks should be between 0 and 100.");
                }
                else
                {
                    string grade = GetGrade(marks);
                    Console.WriteLine($"{name} - Grade: {grade}");
                }
            }

            static string GetGrade(int marks)
            {
                if (marks >= 75 && marks <= 100)
                    return "A";
                else if (marks >= 60 && marks <= 74)
                    return "B";
                else if (marks >= 50 && marks <= 59)
                    return "C";
                else if (marks >= 40 && marks <= 49)
                    return "D";
                else
                    return "Fail";
            }
        }
    }
    

