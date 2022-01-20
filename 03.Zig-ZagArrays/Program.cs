using System;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[numberOfLines];
            int[] arrayTwo = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine();
                string[] inputArray = input.Split(' ');

                if((i + 1) % 2 == 0)
                {
                    arrayOne[i] = int.Parse(inputArray[1]);
                    arrayTwo[i] = int.Parse(inputArray[0]);
                }
                else
                {
                    arrayOne[i] = int.Parse(inputArray[0]);
                    arrayTwo[i] = int.Parse(inputArray[1]);
                }
            }

            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write($"{arrayOne[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.Write($"{arrayTwo[i]} ");
            }
        }
    }
}
