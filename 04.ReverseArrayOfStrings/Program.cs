using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split();
            Array.Reverse(inputArray);

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }
        }
    }
}
