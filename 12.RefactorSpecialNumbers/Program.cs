using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                var currentNumber = i;

                while (currentNumber != 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNum);

                sum = 0;
            }
        }
    }
}
