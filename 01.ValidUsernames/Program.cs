using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main()
        {
            List<string> usernames = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string name in usernames)
            {
                CheckIfValid(name);
            }
                
        }

        public static void CheckIfValid(string userName)
        {
            bool isValid = true;
            bool containsHyphen = false;
            bool containsUnderscore = false;

            if (userName.Length >= 3 && userName.Length <= 16)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            if (isValid)
            {
                foreach (char ch in userName)
                {
                    if (Char.IsLetterOrDigit(ch))
                    {
                        //Passed

                    }
                    else if (ch == '-')
                    {
                        //Passed
                        if (containsHyphen)
                        {
                            isValid = false;
                            break;
                        }
                        containsHyphen = true;
                    }
                    else if (ch == '_')
                    {
                        if (containsUnderscore)
                        {
                            isValid = false;
                            break;
                        }
                        containsUnderscore = true;
                    }
                    else
                    {
                        //Failed
                        isValid = false;
                        break;
                    }
                }
            }

            if (isValid)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
