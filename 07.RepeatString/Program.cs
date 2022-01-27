using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            var repeatedString = RepeatString(input, n);

            Console.WriteLine(repeatedString);
        }

        static string RepeatString(string input, int n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                Console.Write(input);
            }

            return result;
        }
    }
}