using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Dictionary
{
    public class Program
    {
        static void Main()
        {
            List<Word> dictionary = new List<Word>();

            string[] definitions = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var definition in definitions)
            {
                string[] args = definition.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);

                string word = args[0];
                string def = args[1];

                Word currentWord = dictionary.Where(x => x.Name == word).FirstOrDefault();

                if (currentWord == null)
                {
                    dictionary.Add(new Word(word, def));
                }
                else
                {
                    currentWord.Definitions.Add(def);
                }
            }

            string[] words = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            string command = Console.ReadLine();

            if (command == "Test")
            {
                foreach (string word in words)
                {
                    Word currentWord = dictionary.Where(x => x.Name == word).FirstOrDefault();

                    if (currentWord != null)
                    {
                        Console.WriteLine($"{currentWord.Name}:");
                        foreach (var definition in currentWord.Definitions)
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                List<string> wordsToPrint = new List<string>();
                foreach (var word in dictionary)
                {
                    wordsToPrint.Add(word.Name);
                }
                Console.WriteLine(string.Join(" ", wordsToPrint));
            }
        }
    }


    public class Word
    {
        public Word(string word, string def)
        {
            Name = word;
            Definitions.Add(def);
        }
        public string Name { get; set; }
        public List<string> Definitions { get; set; } = new List<string>();
    }
}
