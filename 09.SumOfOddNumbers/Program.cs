using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            int counter = 1;
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (counter <= number)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                        sum += i;
                        counter++;
                    }
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
