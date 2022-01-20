using System;

namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main()
        {
            var meters = int.Parse(Console.ReadLine());
            decimal kilometeres = (decimal)(meters / 1000.00);

            Console.WriteLine($"{kilometeres:F2}");
        }
    }
}
