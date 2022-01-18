using System;

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i <= input - 1; i++)
            {
                for (int j = 0; j <= input - 1; j++)
                {
                    for (int k = 0; k <= input - 1; k++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.WriteLine(firstChar.ToString() + secondChar.ToString() + thirdChar.ToString());
                    }
                }
            }
        }
    }
}
