using System;

namespace _08.TownInfo
{
    internal class Program
    {
        static void Main()
        {
            var townName = Console.ReadLine();
            var population = Console.ReadLine();
            var area = Console.ReadLine();

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
