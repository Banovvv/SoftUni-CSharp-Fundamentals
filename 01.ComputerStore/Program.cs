using System;

namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main()
        {
            double totalPriceWithoutTaxes = 0d;
            double totalTaxes = 0d;
            double discount = 0d;
            bool isRunning = true;

            while (isRunning)
            {
                string input = Console.ReadLine();

                if(input == "special")
                {
                    discount = 0.90;
                    isRunning = false;
                }
                else if (input == "regular")
                {
                    isRunning = false;
                }
                else
                {
                    double price = double.Parse(input);
                    if (price < 0)
                    {
                        Console.WriteLine("Invalid price!");
                    }
                    else
                    {
                        totalPriceWithoutTaxes += price;
                        totalTaxes += price * 0.20;
                    }
                }
            }

            double totalPrice = 0d;
            totalPrice = discount == 0 ? totalPriceWithoutTaxes + totalTaxes : (totalPriceWithoutTaxes + totalTaxes) * discount;

            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:F2}$");
                Console.WriteLine($"Taxes: {totalTaxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");
            }
        }
    }
}