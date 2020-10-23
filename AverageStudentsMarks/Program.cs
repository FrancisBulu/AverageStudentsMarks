using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentsMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int amountOfStudents = Int32.Parse(Console.ReadLine()); // step per step testen!

            double averageGrade = 0; // double omdat wij gebruiken 5,5 bvb. Niet decimal, meestal gebruiken voor geld
            double highestGrade = 0;
            string highestGradeName = "";

            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents];

            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine($"Enter the the student number {i+1} please");
                string name = Console.ReadLine();
                studentNames[i] = name;
                Console.WriteLine($"Enter the grade for student number {i + 1}");
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradeName = name;

                }
            }
            averageGrade /= amountOfStudents; // gemiddelde -> avg = avg / amoOfstu
            Console.WriteLine($"The average grade of the class is {averageGrade}");
            Console.WriteLine($"The highest grade of the class is {highestGrade}");

        }
    }
}
