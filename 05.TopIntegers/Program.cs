using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main()
        {
            int[] intArray = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i == intArray.Length - 1)
                {
                    Console.Write($"{intArray[i]} ");
                }
                else if (intArray[i] > intArray[i + 1])
                {
                    Console.Write($"{intArray[i]} ");
                }
            }
        }
    }
}