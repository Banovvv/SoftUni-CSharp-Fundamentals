using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split().ToArray();
            var rotations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rotations; i++)
            {
                string firstElement = inputArray[0];

                for (int j = 1; j < inputArray.Length; j++)
                {
                    string currentElement = inputArray[j];
                    inputArray[j - 1] = currentElement;
                }
                inputArray[inputArray.Length - 1] = firstElement;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }
        }
    }
}
