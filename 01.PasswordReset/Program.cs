using System;
using System.Text;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] args = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string action = args[0];

                if (action == "TakeOdd")
                {
                    password = TakeOdd(password);
                }
                else if (action == "Cut")
                {
                    password = Cut(password, args);
                }
                else if (action == "Substitute")
                {
                    password = Substitute(password, args);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }

        static string TakeOdd(string password)
        {
            StringBuilder newPassword = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newPassword.Append(password[i]);
                }
            }

            Console.WriteLine(newPassword.ToString());

            return newPassword.ToString();
        }

        static string Cut(string password, string[] args)
        {
            int index = int.Parse(args[1]);
            int length = int.Parse(args[2]);

            password = password.Remove(index, length);

            Console.WriteLine(password);

            return password;
        }

        static string Substitute(string password, string[] args)
        {
            string substring = args[1];
            string substitute = args[2];

            if (password.Contains(substring))
            {
                while (password.Contains(substring))
                {
                    password = password.Replace(substring, substitute);
                }

                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return password;
        }
    }
}
