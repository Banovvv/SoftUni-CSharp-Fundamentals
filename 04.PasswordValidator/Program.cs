using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            PasswordValidator(password);
        }

        static void PasswordValidator(string password)
        {
            bool isValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            int digits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                string characters = "!\"#$%^&*()_-=+,./\\[]|`';:{}~";
                
                if (characters.Contains(password[i].ToString()))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    break;
                }
                if(password[i] >= 48 && password[i] <= 57)
                {
                    digits++;
                }
            }

            if (digits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}