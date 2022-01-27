using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            char charOperator = char.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            double result = GetResult(numberOne, charOperator, numberTwo);

            Console.WriteLine(result);
        }

        static double GetResult(int numberOne, char charOperator, int numberTwo)
        {
            double result = 0d;

            switch (charOperator)
            {
                case '+': result = numberOne + numberTwo; break;
                case '-': result = numberOne - numberTwo; break;
                case '*': result = numberOne * numberTwo; break;
                case '/': result = numberOne / numberTwo; break;
            }

            return result;
        }
    }
}