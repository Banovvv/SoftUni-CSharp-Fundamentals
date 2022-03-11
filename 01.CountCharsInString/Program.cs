using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInString
{
    internal class Program
    {
        static void Main()
        {
            char[] charArray = Console.ReadLine().ToCharArray().Where(c => c != ' ').ToArray();

            Dictionary<char, int> occurencies = new Dictionary<char, int>();

            foreach (char c in charArray)
            {
                if (occurencies.ContainsKey(c))
                {
                    occurencies[c]++;
                }
                else
                {
                    occurencies.Add(c, 1);
                }
            }

            foreach (var c in occurencies)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
