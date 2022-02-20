using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Numbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] args = command.Split();

                if(args[0] == "Add")
                {
                    Add(numbers, args);
                }
                else if (args[0] == "Remove")
                {
                    Remove(numbers, args);
                }
                else if (args[0] == "Replace")
                {
                    Replace(numbers, args);
                }
                else if (args[0] == "Collapse")
                {
                    Collapse(numbers, args);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void Add(List<int> numbers, string[] args)
        {
            int value = int.Parse(args[1]);

            numbers.Add(value);
        }

        static void Remove(List<int> numbers, string[] args)
        {
            int value = int.Parse(args[1]);

            numbers.Remove(value);
        }

        static void Replace(List<int> numbers, string[] args)
        {
            int value = int.Parse(args[1]);
            int replacement = int.Parse(args[2]);

            int index = numbers.IndexOf(value);

            if(index >= 0)
            {
                numbers.RemoveAt(index);
                numbers.Insert(index, replacement);
            }
        }

        static void Collapse(List<int> numbers, string[] args)
        {
            int value = int.Parse(args[1]);

            numbers.RemoveAll(x => x < value);
        }
    }
}
