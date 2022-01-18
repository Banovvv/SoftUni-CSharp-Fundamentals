using System;

namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {(prime ? "true" : "false")}");
            }
        }
    }
}
