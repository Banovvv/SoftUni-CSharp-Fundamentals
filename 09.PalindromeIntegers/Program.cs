using System;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            bool running = true;
            while (running)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    running = false;
                    break;
                }
                else
                {
                    Palindrome(input);
                }
            }
        }

        static void Palindrome(string n)
        {
            char[] chars = n.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine((n == string.Join("", chars)).ToString().ToLower());
        }
    }
}