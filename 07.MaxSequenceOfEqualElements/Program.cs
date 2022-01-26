using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            int counterOne = 0;
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var counterTwo = 0;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        counterTwo++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counterTwo > counterOne)
                {
                    counterOne = counterTwo;
                    index = i;
                }
            }

            for (int i = index; i <= counterOne + index; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}