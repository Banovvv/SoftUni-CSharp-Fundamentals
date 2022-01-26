using System;
using System.Linq;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            if(input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            var position = 0;
            bool equalSides = false;

            for (int i = 0; i < input.Length; i++)
            {
                var leftSum = 0;
                var rigthSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }

                for (int j = input.Length - 1; j > i; j--)
                {
                    rigthSum += input[j];
                }

                if(leftSum == rigthSum)
                {
                    position = i;
                    equalSides = true;
                }
            }

            if (equalSides)
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}