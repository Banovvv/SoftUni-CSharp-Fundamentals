using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    internal class Program
    {
        static void Main()
        {
            int pairOfRows = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < pairOfRows; i++)
            {
                string studentName = Console.ReadLine();
                decimal studentGrade = decimal.Parse(Console.ReadLine());

                if (studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName].Add(studentGrade);
                }
                else
                {
                    studentGrades.Add(studentName, new List<decimal>() { studentGrade });
                }
            }

            foreach(var student in studentGrades.Where(x => x.Value.Average() >= 4.50m))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
