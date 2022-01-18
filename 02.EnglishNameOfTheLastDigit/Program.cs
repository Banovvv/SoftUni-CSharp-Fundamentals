using System;

namespace _02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(EnglishName(number));
        }

        static string EnglishName(int number)
        {
            string name = string.Empty;
            string num = number.ToString();
            char digit = num[num.Length - 1];
            int lastDigit = (int)digit;
            switch (lastDigit)
            {
                case 48:
                    {
                        name = "zero";
                        break;
                    }
                case 49:
                    {
                        name = "one";
                        break;
                    }
                case 50:
                    {
                        name = "two";
                        break;
                    }
                case 51:
                    {
                        name = "three";
                        break;
                    }
                case 52:
                    {
                        name = "four";
                        break;
                    }
                case 53:
                    {
                        name = "five";
                        break;
                    }
                case 54:
                    {
                        name = "six";
                        break;
                    }
                case 55:
                    {
                        name = "seven";
                        break;
                    }
                case 56:
                    {
                        name = "eight";
                        break;
                    }
                case 57:
                    {
                        name = "nine";
                        break;
                    }
            }

            return name;
        }
    }
}
