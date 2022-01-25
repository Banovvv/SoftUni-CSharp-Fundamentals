using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();
            int[] condensedArray = new int[inputArray.Length - 1];

            if (inputArray.Length == 1)
            {
                Console.WriteLine(inputArray[0]);
                return;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < condensedArray.Length - i; j++)
                {
                    condensedArray[j] = inputArray[j] + inputArray[j + 1];
                }

                inputArray = condensedArray;
            }

            Console.WriteLine(condensedArray[0]);
        }
    }
}