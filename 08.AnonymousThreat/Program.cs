using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        // 60 / 100
        static void Main()
        {
            List<string> virus = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    Merge(virus, command);
                }
                else if (command[0] == "divide")
                {
                    Divide(virus, command);
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", virus));
        }

        static List<string> Merge(List<string> virus, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);

            if(startIndex < 0) { startIndex = 0; }
            if(endIndex < 0) { endIndex = 0; }  
            if(startIndex > virus.Count) { startIndex = virus.Count - 1; }
            if(endIndex > virus.Count) { endIndex = virus.Count - 1; }

            StringBuilder mergedSegments = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedSegments.Append(virus[i]);
            }

            virus.RemoveRange(startIndex, endIndex - startIndex + 1);
            virus.Insert(startIndex, mergedSegments.ToString());
            return virus;
        }

        static List<string> Divide(List<string> virus, string[] command)
        {
            int index = int.Parse(command[1]);
            int partitions = int.Parse(command[2]);

            if(partitions == 0)
            {
                return virus;
            }

            List<char> wordToBeSplit = virus[index].ToCharArray().ToList();

            if (partitions > wordToBeSplit.Count)
            {
                return virus;
            }

            int partitionLength = (int)Math.Floor((decimal)wordToBeSplit.Count() / partitions);
            int lastPart = (int)Math.Ceiling((decimal)wordToBeSplit.Count() / partitions);
            List<string> splitWords = new List<string>();

            while (wordToBeSplit.Any())
            {
                if(wordToBeSplit.Count != lastPart)
                {
                    var wordParts = wordToBeSplit.Take(partitionLength);
                    string word = string.Empty;

                    foreach (char part in wordParts)
                    {
                        word += part.ToString();
                    }

                    splitWords.Add(word);
                    wordToBeSplit = wordToBeSplit.Skip(partitionLength).ToList();
                }
                else if (wordToBeSplit.Count == lastPart)
                {
                    var wordParts = wordToBeSplit.Take(lastPart);
                    string word = string.Empty;

                    foreach (char part in wordParts)
                    {
                        word += part.ToString();
                    }

                    splitWords.Add(word);
                    wordToBeSplit = wordToBeSplit.Skip(lastPart).ToList();
                }
            }

            virus.RemoveAt(index);
            virus.AddRange(splitWords);

            return virus;
        }
    }
}
