using System;

namespace _01.StudentInformation
{
    internal class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            decimal grade = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:N2}");
        }
    }
}
