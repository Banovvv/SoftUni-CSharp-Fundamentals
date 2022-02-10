using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] args = command.Split();

                if (args[0] == "Delete")
                {
                    int numberToDelete = int.Parse(args[1]);
                    numbers.RemoveAll(x => x == numberToDelete);
                }
                else if (args[0] == "Insert")
                {
                    int element = int.Parse(args[1]);
                    int position = int.Parse(args[2]);

                    numbers.Insert(position, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
