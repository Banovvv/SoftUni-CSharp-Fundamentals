using System;

namespace _01.SecretChat
{
    public class Program
    {
        static void Main()
        {
            string concealedMessage = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] commandArgs = command.Split(new string[] { ":|:" }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "InsertSpace")
                {
                    concealedMessage = InsertSpace(concealedMessage, commandArgs);
                }
                else if (action == "Reverse")
                {
                    concealedMessage = Reverse(concealedMessage, commandArgs);
                }
                else if (action == "ChangeAll")
                {
                    concealedMessage = ChangeAll(concealedMessage, commandArgs);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }

        //"InsertSpace:|:{index}":
        //  - Inserts a single space at the given index.The given index will always be valid.
        static string InsertSpace(string concealedMessage, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);

            concealedMessage = concealedMessage.Insert(index, " ");

            Console.WriteLine(concealedMessage);
            return concealedMessage;
        }

        //"Reverse:|:{substring}":
        //  - If the message contains the given substring, cut it out, reverse it and add it at the end of the message.
        //  - If not, print "error".
        //  - This operation should replace only the first occurrence of the given substring if there are two or more occurrences.
        static string Reverse(string concealedMessage, string[] commandArgs)
        {
            //List<char> message = concealedMessage.ToCharArray().ToList();
            string substring = commandArgs[1];

            if (concealedMessage.Contains(substring))
            {
                int index = concealedMessage.IndexOf(substring);
                concealedMessage = concealedMessage.Remove(index, substring.Length);

                char[] chars = substring.ToCharArray();
                Array.Reverse(chars);

                concealedMessage += string.Join("", chars);

                Console.WriteLine(concealedMessage);
            }
            else
            {
                Console.WriteLine("error");
            }

            return concealedMessage;
        }

        //"ChangeAll:|:{substring}:|:{replacement}":
        //  - Changes all occurrences of the given substring with the replacement text.
        static string ChangeAll(string concealedMessage, string[] commandArgs)
        {
            string substring = commandArgs[1];
            string replacement = commandArgs[2];

            while (concealedMessage.Contains(substring))
            {
                concealedMessage = concealedMessage.Replace(substring, replacement);
            }

            Console.WriteLine(concealedMessage);
            return concealedMessage;
        }
    }
}
