using System;
using System.Linq;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main()
        {
            int[] arrayOne = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
            int[] arrayTwo = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            bool areIdentical = true;
            int diffIndex = 0;
            int sum = 0;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if(arrayOne[i] != arrayTwo[i])
                {
                    areIdentical = false;
                    diffIndex = i;
                    break;
                }
                sum += arrayOne[i];
            }

            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");
            }
        }
    }
}