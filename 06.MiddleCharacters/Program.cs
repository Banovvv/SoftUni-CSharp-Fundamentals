using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            MiddleCharacters(input);
        }

        static void MiddleCharacters(string input)
        {
            if(input.Length % 2 != 0)
            {
                string middleChar = input[(input.Length - 1) / 2].ToString();
                Console.WriteLine(middleChar);
            }
            else
            {
                string middleChar = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
                Console.WriteLine(middleChar);
            }
        }
    }
}
