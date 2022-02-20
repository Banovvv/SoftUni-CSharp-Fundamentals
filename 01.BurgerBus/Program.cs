using System;

namespace _01.BurgerBus
{
    internal class Program
    {
        static void Main()
        {
            int numberOfCities = int.Parse(Console.ReadLine());

            decimal totalIncome = 0;
            decimal totalExpenses = 0;

            for (int i = 1; i <= numberOfCities; i++)
            {
                string city = Console.ReadLine();
                decimal income = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());

                
                if (i % 5 == 0)
                {
                    income *= 0.90m;
                }
                else if (i % 3 == 0)
                {
                    expenses *= 1.50m;
                }

                totalExpenses += expenses;
                totalIncome += income;

                Console.WriteLine($"In {city} Burger Bus earned {(income - expenses):F2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {(totalIncome - totalExpenses):F2} leva.");
        }
    }
}
