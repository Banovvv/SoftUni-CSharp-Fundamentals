using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while(command[0] != "end")
            {
                if(command[0] == "swap")
                {
                    Swap(numbers, command);
                }
                else if (command[0] == "multiply")
                {
                    Multiply(numbers, command);
                }
                else if (command[0] == "decrease")
                {
                    Decrease(numbers);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void Swap(List<int> numbers, string[] command)
        {
            int firstIndex = int.Parse(command[1]);
            int secondIndex = int.Parse(command[2]);

            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }

        static void Multiply(List<int> numbers, string[] command)
        {
            int firstIndex = int.Parse(command[1]);
            int secondIndex = int.Parse(command[2]);

            numbers[firstIndex] *= numbers[secondIndex];
        }

        static void Decrease(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= 1;
            }
        }
    }
}
