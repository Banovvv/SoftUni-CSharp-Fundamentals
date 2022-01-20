using System;

namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main()
        {
            var pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * (decimal)1.31;

            Console.WriteLine($"{dollars:F3}");
        }
    }
}
