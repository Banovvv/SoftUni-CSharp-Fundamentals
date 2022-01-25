using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] % 2 == 0)
                {
                    evenSum += input[i];
                }
                else
                {
                    oddSum += input[i];
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}