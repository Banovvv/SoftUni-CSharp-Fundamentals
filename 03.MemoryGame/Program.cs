using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int moves = 0;

            while (command[0] != "end")
            {
                int firstIndex = int.Parse(command[0]);
                int secondIndex = int.Parse(command[1]);

                moves++;

                if (firstIndex == secondIndex || (firstIndex < 0 || firstIndex >= elements.Count) || (secondIndex < 0 || secondIndex >= elements.Count))
                {
                    if (elements.Count != 0)
                    {
                        AddElements(elements, moves);
                    }
                }
                else
                {
                    CheckElements(elements, firstIndex, secondIndex);
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }

                command = Console.ReadLine().Split();
            }

            if (elements.Count != 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }

        static void CheckElements(List<string> elements, int firstIndex, int secondIndex)
        {
            if (elements[firstIndex] == elements[secondIndex])
            {
                Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                if (firstIndex < secondIndex)
                {
                    elements.RemoveAt(firstIndex);
                    elements.RemoveAt(secondIndex - 1);
                }
                else
                {
                    elements.RemoveAt(secondIndex);
                    elements.RemoveAt(firstIndex - 1);
                }
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }

        static void AddElements(List<string> elements, int moves)
        {
            int middleIndex = elements.Count / 2;
            elements.InsertRange(middleIndex, new string[] { $"-{moves}a", $"-{moves}a" });

            Console.WriteLine("Invalid input! Adding additional elements to the board");
        }
    }
}
