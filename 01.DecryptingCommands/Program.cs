using System;
using System.Linq;

namespace _01.DecryptingCommands
{
    public class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] args = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string action = args[0];

                if (action == "Replace")
                {
                    string substring = args[1];
                    string substitute = args[2];

                    message = Replace(message, substring, substitute);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(args[1]);
                    int endIndex = int.Parse(args[2]);

                    message = Cut(message, startIndex, endIndex);
                }
                else if (action == "Make")
                {
                    string _case = args[1];

                    message = Make(message, _case);
                }
                else if (action == "Check")
                {
                    string substring = args[1];

                    Check(message, substring);
                }
                else if (action == "Sum")
                {
                    int startIndex = int.Parse(args[1]);
                    int endIndex = int.Parse(args[2]);

                    Sum(message, startIndex, endIndex);
                }

                command = Console.ReadLine();
            }
        }

        //"Replace {currentChar} {newChar}"
        public static string Replace(string message, string substring, string substitute)
        {
            if (message.Contains(substring))
            {
                message = message.Replace(substring, substitute);

            }

            Console.WriteLine(message);

            return message;
        }
        //"Cut {startIndex} {endIndex}"
        public static string Cut(string message, int startIndex, int endIndex)
        {
            if (startIndex > 0 && startIndex < message.Length && endIndex > 0 && endIndex < message.Length)
            {
                message = message.Remove(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Invalid indices!");
            }
            return message;
        }
        //"Make {Upper/Lower}"
        public static string Make(string message, string _case)
        {
            if (_case == "Lower")
            {
                message = message.ToLower();
            }
            else if (_case == "Upper")
            {
                message = message.ToUpper();
            }

            Console.WriteLine(message);

            return message;
        }
        //"Check" {string}
        public static void Check(string message, string substring)
        {
            if (message.Contains(substring))
            {
                Console.WriteLine($"Message contains {substring}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {substring}");
            }
        }
        //"Sum {startIndex} {endIndex}"
        public static void Sum(string message, int startIndex, int endIndex)
        {
            if (startIndex > 0 && startIndex < message.Length && endIndex > 0 && endIndex < message.Length)
            {
                string substring = message.Substring(startIndex, endIndex);
                int sum = substring.Sum(x => x);

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Invalid indices!");
            }
        }
    }
}
