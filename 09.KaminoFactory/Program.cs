using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.KaminoFactory
{
    // 70/100
    internal class Program
    {
        static void Main()
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            int[] bestSequence = new int[sequenceLength];
            int bestSequenceIndex = sequenceLength;
            int bestSequenceSum = 0;
            bool stop = false;
            int index = 0;
            int bestIndex = sequenceLength;

            do
            {
                string input = Console.ReadLine();
                if (input != "Clone them!")
                {
                    int[] sequence = Regex.Split(input, @"(?<!-)!(?!-)")
                                          .Where(item => !string.IsNullOrEmpty(item))
                                          .Select(int.Parse)
                                          .ToArray();
                    int sum = 0;
                    index++;

                    for (int i = 0; i < sequence.Length; i++)
                    {
                        sum += sequence[i];
                        if (i + 1 < sequence.Length)
                        {
                            if (sequence[i] == 1 && sequence[i + 1] == 1)
                            {
                                if (bestIndex > i)
                                {
                                    bestIndex = i;
                                }
                            }
                        }
                    }

                    if (sum > bestSequenceSum || bestIndex < input.Length)
                    {
                        bestSequence = sequence;
                        bestSequenceSum = sum;
                        bestSequenceIndex = index;
                    }
                }
                else
                {
                    stop = true;
                    break;
                }
            }
            while (!stop);

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}