using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = studentsInfo[0];
                double grade = double.Parse(studentsInfo[1]);

                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade[name] = new List<double>();
                }
                studentsGrade[name].Add(grade);
            }

            foreach (var kvp in studentsGrade)
            {
                Console.Write($"{kvp.Key} -> ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
