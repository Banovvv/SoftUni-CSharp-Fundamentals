using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        // 83 / 100 - Fails on the last two tests
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();
                ListOperation(numbers, args);
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> ListOperation(List<int> numbers, string[] args)
        {
            string operation = args[0];

            if (operation == "Add")
            {
                int numberToAdd = int.Parse(args[1]);
                numbers.Add(numberToAdd);
            }
            else if (operation == "Insert")
            {
                int numberToInsert = int.Parse(args[1]);
                int indexToInsertAt = int.Parse(args[2]);

                if (indexToInsertAt < numbers.Count)
                {
                    numbers.Insert(indexToInsertAt, numberToInsert); 
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (operation == "Remove")
            {
                int indexToRemoveAt = int.Parse(args[1]);

                if (indexToRemoveAt < numbers.Count)
                {
                    numbers.RemoveAt(indexToRemoveAt); 
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (operation == "Shift")
            {
                string direction = args[1];
                int count = int.Parse(args[2]);

                if (direction == "left")
                {
                    ShiftLeft(numbers, count);
                }
                else if (direction == "right")
                {
                    ShiftRigth(numbers, count);
                }
            }

            return numbers;
        }

        static List<int> ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                int first = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(first);
            }

            return numbers;
        }
        static List<int> ShiftRigth(List<int> numbers, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                int last = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, last);
            }

            return numbers;
        }
    }
}
