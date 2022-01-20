using System;

namespace _01.SoftUniReception
{
    internal class Program
    {
        static void Main()
        {
            var employeeOne = int.Parse(Console.ReadLine());
            var employeeTwo = int.Parse(Console.ReadLine());
            var employeeThree = int.Parse(Console.ReadLine());
            var numberOfStudents = int.Parse(Console.ReadLine());
            int timeNeeded = 0;
            var studentsPerHour = employeeOne + employeeTwo + employeeThree;

            for (int i = numberOfStudents; i > 0;)
            {
                timeNeeded++;

                if (timeNeeded % 4 == 0)
                {
                    continue;
                }
                else
                {
                    i -= studentsPerHour;
                }
            }

            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
