using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main()
        {
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            TotalSum(order, quantity);
        }

        static void TotalSum(string order, int quantity)
        {
            double sum = 0.0;

            switch (order)
            {
                case "coffee": sum = quantity * 1.50; break;
                case "water": sum = quantity * 1.00; break;
                case "coke": sum = quantity * 1.40; break;
                case "snacks": sum = quantity * 2.00; break;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}