using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<WordPair> wordPairs = new List<WordPair>();
            List<WordPair> mirrorWords = new List<WordPair>();

            string pattern = @"(\@|\#)(?<wordOne>[A-z]{3,})\1\1(?<wordTwo>[A-z]{3,})\1";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["wordOne"].Value;
                string secondWord = match.Groups["wordTwo"].Value;

                WordPair currentPair = new WordPair(firstWord, secondWord);
                wordPairs.Add(new WordPair(firstWord, secondWord));

                if (currentPair.AreMatching())
                {
                    mirrorWords.Add(currentPair);
                }
            }

            if (wordPairs.Count > 0)
            {
                Console.WriteLine($"{wordPairs.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (mirrorWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");

                Console.WriteLine(string.Join(", ", mirrorWords));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }

    public class WordPair
    {
        public WordPair(string firstWord, string secondWord)
        {
            FirstWord = firstWord;
            SecondWord = secondWord;
        }
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }

        public bool AreMatching()
        {
            char[] secondWordReversed = SecondWord.ToCharArray();
            Array.Reverse(secondWordReversed);
            return FirstWord == string.Join("", secondWordReversed);
        }

        public override string ToString()
        {
            return $"{FirstWord} <=> {SecondWord}";
        }
    }
}
