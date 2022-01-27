using System;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main()
        {
            string method = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            Calculate(method, numberOne, numberTwo);
        }

        static void Calculate(string methond, int numberOne, int numberTwo)
        {
            int result = 0;

            switch (methond)
            {
                case "add": result = numberOne + numberTwo; break;
                case "multiply": result = numberOne * numberTwo; break;
                case "subtract": result = numberOne - numberTwo; break;
                case "divide": result = numberOne / numberTwo; break;
                default:
                    break;
            }

            Console.WriteLine(result);
        }
    }
}