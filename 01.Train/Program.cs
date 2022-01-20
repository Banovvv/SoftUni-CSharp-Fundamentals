using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main()
        {
            var numberOfWagons = int.Parse(Console.ReadLine());
            int[] passangers = new int[numberOfWagons];
            int totalPassangers = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                totalPassangers += passangers[i];
            }

            for (int j = 0; j < passangers.Length; j++)
            {

                Console.Write($"{passangers[j]} ");
            }

            Console.WriteLine(Environment.NewLine + totalPassangers);
        }
    }
}
