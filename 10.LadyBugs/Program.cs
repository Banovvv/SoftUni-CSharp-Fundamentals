using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            // If no ladybugs, terminate
            if (ladyBugIndexes.Length == 0)
            {
                return;
            }

            // Initialize the field
            for (int i = 0; i < field.Length; i++)
            {
                if (ladyBugIndexes.Contains(i))
                { 
                    field[i] = 1;
                }
            }

            string rawInput;

            while ((rawInput = Console.ReadLine()) != "end")
            {
                string[] inputArgs = rawInput.Split();

                int ladyBugIndex = int.Parse(inputArgs[0]);
                string direction = inputArgs[1];
                int moveLength = int.Parse(inputArgs[2]);

                // Check if index is valid, if it isn't do nothing
                if(ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    continue;
                }

                // Check if there is a ladybug, if there isn't do nothing
                if(field[ladyBugIndex] == 0)
                {
                    continue;
                }

                int newPosition = ladyBugIndex;
                field[ladyBugIndex] = 0; // It starts flying

                while (true)
                {
                    if (direction == "rigth")
                    {
                        newPosition += moveLength; 
                    }
                    else if (direction == "left")
                    {
                        newPosition -= moveLength;
                    }

                    if (newPosition < 0 || newPosition >= field.Length)
                    {
                        break; // new index out of bounds, terminate
                    }

                    if (field[newPosition] == 0)
                    {
                        break;
                    }
                }

                if(newPosition >= 0 && newPosition < field.Length)
                {
                    field[newPosition] = 1;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}