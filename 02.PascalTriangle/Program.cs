using System;
using System.Linq;

namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            numbers[0] = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    Console.Write($"{numbers[i + j]}");
                    numbers[j + 1] = 1;
                }
                Console.WriteLine();
            }
        }
    }
}