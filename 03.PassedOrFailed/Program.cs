using System;

namespace _03.PassedOrFailed
{
    internal class Program
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade > 2.99)
            {
                Console.WriteLine($"Passed!");
            }
            else
            {
                Console.WriteLine($"Failed!");
            }
        }
    }
}
