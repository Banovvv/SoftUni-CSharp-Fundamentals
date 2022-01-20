using System;

namespace _03.Numbers
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            int[] numbers = new int[input.Length];
            int largerNumbersCount = 1;
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
                sum += numbers[i];
            }

            decimal average = sum / (decimal)numbers.Length;
            Array.Sort(numbers);

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > average && largerNumbersCount <= 5)
                {
                    Console.Write($"{numbers[i]} ");
                    largerNumbersCount++;
                }
            }

            if (largerNumbersCount == 1)
            {
                Console.WriteLine("No");
            }
        }
    }
}