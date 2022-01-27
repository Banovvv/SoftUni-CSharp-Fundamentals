using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string one = Console.ReadLine();
            string two = Console.ReadLine();

            switch (type)
            {
                case "int": Console.WriteLine(GetMax(int.Parse(one), int.Parse(two))); break;
                case "char": Console.WriteLine(GetMax(char.Parse(one), char.Parse(two))); break;
                case "string": Console.WriteLine(GetMax(one, two)); break;
            }
        }

        static int GetMax(int one, int two)
        {
            if (one > two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }

        static char GetMax(char one, char two)
        {
            if (one > two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }

        static string GetMax(string one, string two)
        {
            int compare = string.Compare(one, two);

            if (compare < 0)
            {
                return two;
            }
            else
            {
                return one;
            }
        }
    }
}