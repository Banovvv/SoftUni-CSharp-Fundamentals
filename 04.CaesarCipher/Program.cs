using System;
using System.Collections.Generic;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main()
        {
            string textToEncrypt = Console.ReadLine();
            List<char> encriptedText = new List<char>();

            foreach (char c in textToEncrypt)
            {
                encriptedText.Add((char)(c + 3));
            }

            Console.WriteLine(string.Join("", encriptedText));
        }
    }
}
