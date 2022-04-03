using System;
using System.Text.RegularExpressions;

namespace _02.EncryptingPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();

                string pattern = @"(?<start>[\S]{1,})>(?<numbers>[0-9]{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<symbols>[\S]{3})<\1";

                Match match = Regex.Match(password, pattern);

                if (match.Success)
                {
                    string numbers = match.Groups["numbers"].Value;
                    string lower = match.Groups["lower"].Value;
                    string upper = match.Groups["upper"].Value;
                    string symbols = match.Groups["symbols"].Value;
                    string encrypted = numbers + lower + upper + symbols;

                    Console.WriteLine($"Password: {encrypted}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
