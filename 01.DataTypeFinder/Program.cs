using System;

namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main()
        {
            var stop = false;

            while (!stop)
            {
                string input = Console.ReadLine();
                if (input != "END")
                {
                    if (input.Length == 1 && !int.TryParse(input, out int notInteger))
                    {
                        Console.WriteLine($"{input} is character type");
                    }
                    else if (int.TryParse(input, out int integer))
                    {
                        Console.WriteLine($"{input} is integer type");
                    }
                    else if (float.TryParse(input.Trim(), out float floatingPoint))
                    {
                        Console.WriteLine($"{input} is floating point type");
                    }
                    else if (bool.TryParse(input, out bool boolean))
                    {
                        Console.WriteLine($"{input} is boolean type");
                    }
                    else
                    {
                        Console.WriteLine($"{input} is string type");
                    } 
                }
                else
                {
                    stop = true;
                }
            }
        }
    }
}
