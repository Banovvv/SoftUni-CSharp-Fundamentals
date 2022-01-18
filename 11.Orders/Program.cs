using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main()
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            while (numberOfOrders > 0)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double priceOfCoffe = (days * capsuleCount) * pricePerCapsule;
                totalPrice += priceOfCoffe;

                Console.WriteLine($"The price for the coffee is: ${(Math.Round(priceOfCoffe, 2)):F2}");

                numberOfOrders--;
            }

            Console.WriteLine($"Total: ${(Math.Round(totalPrice, 2, MidpointRounding.AwayFromZero)):F2}");
        }
    }
}
