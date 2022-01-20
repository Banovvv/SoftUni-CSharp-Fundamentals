using System;

namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                var number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
