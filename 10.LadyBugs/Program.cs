using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] ladyBugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool end = false;

            if(ladyBugIndexes.Length == 0)
            {
                return;
            }

            for (int i = 0; i < ladyBugIndexes.Length; i++)
            {
                if(ladyBugIndexes[i] > field.Length)
                {
                    return;
                }
                else
                {
                    field[ladyBugIndexes[i]] = 1; 
                }
            }

            while (!end)
            {
                string rawInput = Console.ReadLine();

                if (rawInput == "end")
                {
                    end = true;
                    break;
                }
                else
                {
                    string[] input = rawInput.Split();
                    int ladyBugIndex = int.Parse(input[0]);
                    string direction = input[1];
                    int moveLength = int.Parse(input[2]);
                    int newPosition = 0;
                    if(field[ladyBugIndex] == 1)
                    {
                        if(direction == "left")
                        {
                            newPosition = ladyBugIndex - moveLength;
                        }
                        else if (direction == "right")
                        {
                            newPosition = ladyBugIndex + moveLength;
                        }

                        if (newPosition < field.Length && newPosition > 0)
                        {
                            if (field[newPosition] == 1)
                            {
                                while (field[newPosition] == 1)
                                {
                                    if (newPosition == field.Length - 1)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        newPosition++;
                                    }
                                }
                                if (newPosition >= field.Length && newPosition < 0)
                                {
                                    field[ladyBugIndex] = 0;
                                }
                                else
                                {
                                    field[newPosition] = 1;
                                    field[ladyBugIndex] = 0;
                                }
                            }
                            else
                            {
                                field[newPosition] = 1;
                                field[ladyBugIndex] = 0;
                            } 
                        }
                        else
                        {
                            field[ladyBugIndex] = 0;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}