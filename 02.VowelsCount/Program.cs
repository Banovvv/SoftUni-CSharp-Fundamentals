using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            VowelsCount(input);
        }

        static void VowelsCount(string input)
        {
            char[] chars = input.ToCharArray();
            string vowels = "AEIOUaeiou";
            int vowelsCount = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (vowels.Contains(chars[i].ToString()))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}