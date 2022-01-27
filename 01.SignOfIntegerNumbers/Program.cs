using System;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            IntegerSign(input);
        }

        static void IntegerSign(int n)
        {
            if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }

            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
        }
    }
}