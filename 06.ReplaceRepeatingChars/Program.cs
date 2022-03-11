using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            List<char> chars = text.ToCharArray().ToList();

            for (int i = 0; i < chars.Count - 1; i++)
            {
                while (chars[i] == chars[i + 1])
                {
                    chars.RemoveAt(i + 1);

                    if (i + 1 >= chars.Count)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join("", chars));
        }
    }
}
