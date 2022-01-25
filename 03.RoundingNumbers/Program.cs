using System;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main()
        {
            // For some reason this gets 75/100
            string[] inputArray = Console.ReadLine().Split();
            double[] array = new double[inputArray.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(inputArray[i]);

                Console.WriteLine($"{array[i]} => {Math.Round(array[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}