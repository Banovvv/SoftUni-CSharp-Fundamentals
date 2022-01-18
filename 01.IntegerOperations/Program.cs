using System;

namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());
            int sum = 0;

            sum += numberOne + numberTwo;
            sum /= numberThree;
            sum *= numberFour;

            Console.WriteLine(sum);
        }
    }
}
