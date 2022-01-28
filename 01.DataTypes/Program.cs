using System;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if(input == "int")
            {
                DataType(int.Parse(Console.ReadLine()));
            }
            else if (input == "real")
            {
                DataType(double.Parse(Console.ReadLine()));
            }
            else if (input == "string")
            {
                DataType(Console.ReadLine());
            }
        }

        static void DataType(int n)
        {
            Console.WriteLine($"{n * 2}");
        }
        static void DataType(double n)
        {
            Console.WriteLine($"{(n * 1.50):F2}");
        }
        static void DataType(string n)
        {
            Console.WriteLine($"${n}$");
        }
    }
}