using System;
using System.Text;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            char[] character = new char[number];
            int sum = 0;

            for (int i = 0; i <= number - 1; i++)
            {
                character[i] = char.Parse(Console.ReadLine());
            }

            var bites = Encoding.ASCII.GetBytes(character);
            foreach (var bite in bites)
            {
                sum += bite;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
