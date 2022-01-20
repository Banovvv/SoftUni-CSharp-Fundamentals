using System;

namespace _09.CharsToString
{
    internal class Program
    {
        static void Main()
        {
            string message = string.Empty;

            for (int i = 1; i <= 3; i++)
            {
                var input = char.Parse(Console.ReadLine()); 
                message += input;
            }

            Console.WriteLine(message);
        }
    }
}
