using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] args = command.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string courseName = args[0].Trim();
                string studentName = args[1].Trim();

                if (courses.ContainsKey(courseName))
                {
                    courses.Where(x => x.Key == courseName).ToList().ForEach(x => x.Value.Add(studentName));
                }
                else
                {
                    courses.Add(courseName, new List<string>() { studentName });
                }

                command = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count()}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
