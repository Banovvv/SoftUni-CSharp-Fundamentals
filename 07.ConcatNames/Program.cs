using System;

namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nameOne = Console.ReadLine();
            var nameTwo = Console.ReadLine();
            var delimiter = Console.ReadLine();

            Console.WriteLine($"{nameOne}{delimiter}{nameTwo}");
        }
    }
}
