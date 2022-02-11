using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] args = Console.ReadLine().Split().ToArray();

            int bomb = int.Parse(args[0]);
            int power = int.Parse(args[1]);

            int bombPosition = -1;

            while (numbers.Contains(bomb))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == bomb)
                    {
                        bombPosition = i;
                    }
                }

                int startIndex = bombPosition - power < 0 ? 0 : bombPosition - power;
                int endIndex = bombPosition + power > numbers.Count - 1 ? numbers.Count - 1 : bombPosition + power;
                int elementsToRemove = Math.Abs(endIndex - startIndex);
                numbers.RemoveRange(startIndex, elementsToRemove + 1);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
