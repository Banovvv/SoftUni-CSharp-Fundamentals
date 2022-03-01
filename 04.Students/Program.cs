using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    internal class Program
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] stutentParams = Console.ReadLine().Split();

                string firstName = stutentParams[0];
                string lastName = stutentParams[1];
                double grade = double.Parse(stutentParams[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students = students.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
