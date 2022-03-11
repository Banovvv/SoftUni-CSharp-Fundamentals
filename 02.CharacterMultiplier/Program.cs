using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            int sum = FindSum(words);

            Console.WriteLine(sum);
        }

        static int FindSum(List<string> words)
        {
            string shortestWord = words[0].Length >= words[1].Length ? words[1] : words[0];
            string longestWord = words[0].Length >= words[1].Length ? words[0] : words[1];

            int shortestLength = shortestWord.Length;
            int longestLength = longestWord.Length;

            int sum = 0;

            for (int i = 0; i < shortestLength; i++)
            {
                sum += shortestWord[i] * longestWord[i];
            }

            for (int i = shortestLength; i < longestLength; i++)
            {
                sum += longestWord[i];
            }

            return sum;
        }
    }
}
