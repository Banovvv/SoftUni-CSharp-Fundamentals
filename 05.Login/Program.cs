using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string password = "";
            int length = username.Length - 1;
            while (length >= 0)
            {
                password += username[length];
                length--;
            }

            for (int i = 0; i <= 3; i++)
            {
                string input = Console.ReadLine();
                if (input.Equals(password))
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (i != 3)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                }
            }
        }
    }
}
