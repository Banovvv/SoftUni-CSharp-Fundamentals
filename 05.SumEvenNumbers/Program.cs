using System;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            string[] inputArray = Console.ReadLine().Split();
            int[] array = new int[inputArray.Length];
            int sum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = int.Parse(inputArray[i]);
                if (array[i] % 2 == 0)
                {
                    sum += array[i]; 
                }
            }

            Console.WriteLine(sum);
        }
    }
}