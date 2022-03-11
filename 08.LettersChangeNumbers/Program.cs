using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            decimal sum = 0;

            foreach (string word in words)
            {
                sum += CalculateSum(word);
            }

            Console.WriteLine($"{sum:F2}");
        }

        static decimal CalculateSum(string word)
        {
            decimal sum = 0;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int number = int.Parse(word.Substring(1, word.Length - 2));

            // Actions with the first letter
            if (char.IsLower(firstLetter))
            {
                decimal position = firstLetter - 96;
                sum += number * position;
            }
            else
            {
                decimal position = firstLetter - 64;
                sum += number / position;
            }

            // Actions with the last letter
            if (char.IsLower(lastLetter))
            {
                decimal position = lastLetter - 96;
                sum += position;
            }
            else
            {
                decimal position = lastLetter - 64;
                sum -= position;
            }

            return sum;
        }
    }
}
