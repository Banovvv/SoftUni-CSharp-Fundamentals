using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                for (int j = i; j != 0; j /= 10)
                {
                    sum += j % 10;
                }

                Console.WriteLine($"{i} -> {(sum == 5 || sum == 7 || sum == 11 ? "True" : "False")}");

                sum = 0;
            }

        }
    }
}
