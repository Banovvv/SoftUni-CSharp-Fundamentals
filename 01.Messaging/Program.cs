using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<char> inputText = Console.ReadLine().ToCharArray().ToList();
            List<char> message = new List<char>();

            foreach (var number in numbers)
            {
                int currentSum = 0;

                foreach (var digit in number)
                {
                    currentSum += int.Parse(digit.ToString());
                }

                if (currentSum <= inputText.Count - 1)
                {
                    message.Add(inputText[currentSum]);
                    inputText.RemoveAt(currentSum);
                }
                else
                {
                    message.Add(inputText[currentSum - inputText.Count]);
                    inputText.RemoveAt(currentSum - inputText.Count);
                }
            }

            Console.WriteLine(string.Join("", message));
        }
    }
}
