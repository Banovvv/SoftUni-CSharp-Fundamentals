using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int finnishLine = numbers.Count() / 2;
            double firstCar = 0;
            double secondCar = 0;

            for (int i = 0; i < finnishLine; i++)
            {
                if (numbers[i] != 0)
                {
                    firstCar += numbers[i];
                }
                else
                {
                    firstCar *= 0.8;
                }
            }

            for (int i = numbers.Count - 1; i > finnishLine; i--)
            {
                if (numbers[i] != 0)
                {
                    secondCar += numbers[i];
                }
                else
                {
                    secondCar *= 0.8;
                }
            }

            if (firstCar < secondCar)
            {
                Console.WriteLine($"The winner is left with total time: {firstCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondCar}");
            }
        }
    }
}
