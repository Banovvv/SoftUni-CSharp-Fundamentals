﻿using System;

namespace _04.ReverseString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine(output);
        }
    }
}
