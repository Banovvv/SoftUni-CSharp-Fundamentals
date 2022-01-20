using System;

namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main()
        {
            var numberIsEven = false;

            while (!numberIsEven)
            {
                var number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    numberIsEven = true;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
