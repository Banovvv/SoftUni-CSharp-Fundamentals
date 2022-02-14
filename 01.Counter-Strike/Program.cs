﻿using System;

namespace _01.Counter_Strike
{
    internal class Program
    {
        static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int wins = 0;

            while (input != "End of battle")
            {
                int distance = int.Parse(input);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    return;
                }

                wins++;
                energy -= distance;

                if (wins % 3 == 0)
                {
                    energy += wins;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
        }
    }
}
