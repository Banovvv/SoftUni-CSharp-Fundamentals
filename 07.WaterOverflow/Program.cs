using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int capacity = 0;
            int water;

            for (int i = 1; i <= numberOfLines; i++)
            {
                water = int.Parse(Console.ReadLine());
                if (capacity + water > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity += water;
                }
            }

            Console.WriteLine(capacity);
        }
    }
}
