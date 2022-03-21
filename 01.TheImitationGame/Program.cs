using System;
using System.Text;

namespace _01.TheImitationGame
{
    public class Program
    {
        static void Main()
        {
            string encryptedMessage = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandArgs = command.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "Move")
                {
                    encryptedMessage = Move(encryptedMessage, commandArgs);
                }
                else if (action == "Insert")
                {
                    encryptedMessage = Insert(encryptedMessage, commandArgs);
                }
                else if (action == "ChangeAll")
                {
                    encryptedMessage = ChangeAll(encryptedMessage, commandArgs);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }

        //"Move {number of letters}":
        //    - Moves the first n letters to the back of the string
        static string Move(string encryptedMessage, string[] commandArgs)
        {
            StringBuilder result = new StringBuilder();
            result.Append(encryptedMessage);

            int count = int.Parse(commandArgs[1]);

            string lettersToBeMoved = encryptedMessage.Substring(0, count);

            result.Remove(0, count);
            result.Append(lettersToBeMoved);

            return result.ToString();
        }

        //"Insert {index} {value}":
        //    - Inserts the given value before the given index in the string
        static string Insert(string encryptedMessage, string[] commandArgs)
        {
            StringBuilder result = new StringBuilder();
            result.Append(encryptedMessage);

            int index = int.Parse(commandArgs[1]);
            string value = commandArgs[2];

            result.Insert(index, value);

            return result.ToString();
        }

        //"ChangeAll {substring} {replacement}":
        //    - Changes all occurrences of the given substring with the replacement text
        static string ChangeAll(string encryptedMessage, string[] commandArgs)
        {
            string substring = commandArgs[1];
            string replacement = commandArgs[2];

            while (encryptedMessage.Contains(substring))
            {
                encryptedMessage = encryptedMessage.Replace(substring, replacement);
            }

            return encryptedMessage;
        }
    }
}
