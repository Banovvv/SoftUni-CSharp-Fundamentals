using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main()
        {
            string[] initialArray = Console.ReadLine().Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<int> numbers = new List<int>();

            for (int i = initialArray.Length - 1; i >= 0; i--)
            {
                int[] arrayNumbers = initialArray[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                numbers.AddRange(arrayNumbers);
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
