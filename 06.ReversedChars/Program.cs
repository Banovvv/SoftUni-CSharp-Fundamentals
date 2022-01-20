using System;

namespace _06.ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var charOne = char.Parse(Console.ReadLine());
            var charTwo = char.Parse(Console.ReadLine());
            var charThree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{charThree} {charTwo} {charOne}");
        }
    }
}
