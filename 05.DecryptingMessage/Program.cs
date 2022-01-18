using System;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main()
        {
            var key = int.Parse(Console.ReadLine());
            var numberOfLines = int.Parse(Console.ReadLine());
            string message = String.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                var character = char.Parse(Console.ReadLine());
                message += (char)(character + key);
            }

            Console.WriteLine(message);
        }
    }
}
