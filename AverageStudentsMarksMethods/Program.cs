using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentsMarksMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfStudents = GetAmountOfStudents();
            ProcessAllData(amountOfStudents);

        }
        static int GetAmountOfStudents()
        {
            Console.WriteLine("Enter the number of students");
            int amountOfStudents = Int32.Parse(Console.ReadLine());
            return amountOfStudents;
        }
        static void ProcessAllData(int amountOfStudents)
        {
            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";

            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents];

            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine($"Enter the Name of the student number {i + 1} please");
                string name = Console.ReadLine();
                studentNames[i] = name;
                Console.WriteLine($"Enter the grade for student number {i + 1}");
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;
                //*********
                if (FindHighestGrade(grade, highestGrade))
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }

                //**********
            }
            averageGrade = averageGrade / amountOfStudents;
            PrintToScreen(averageGrade, highestGrade, highestGradeName);
        }
        static void PrintToScreen(double averageGrade, double highestGrade, string highestGradeName)
        {
            
            Console.WriteLine($"The average grade of the class is {string.Format("{0:0.00}", averageGrade)}");
            Console.WriteLine($"The highest grade of the class is {highestGrade}");
            Console.WriteLine($"The highest grade student is {highestGradeName}");

        }
        static bool FindHighestGrade(double grade, double highestGrade)
        {
            if (grade > highestGrade)
            {
               
                return true;
            }
            return false;
        }
    }
}
