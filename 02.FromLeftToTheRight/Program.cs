using System;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string numbers = Console.ReadLine();
                string[] number = numbers.Split(' ');
                long numberOne = long.Parse(number[0]);
                long numberTwo = long.Parse(number[1]);

                if (numberOne > numberTwo)
                {
                    long sum = 0;

                    while (numberOne != 0)
                    {
                        sum += numberOne % 10;
                        numberOne /= 10;

                    }
                    
                    Console.WriteLine(Math.Abs(sum));
                }
                else
                {
                    long sum = 0;

                    while (numberTwo != 0)
                    {
                        sum += numberTwo % 10;
                        numberTwo /= 10;

                    }

                    Console.WriteLine(Math.Abs(sum));
                }
            }
        }
    }
}
