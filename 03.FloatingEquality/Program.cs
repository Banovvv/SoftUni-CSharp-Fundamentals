using System;

namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main()
        {
            var numberOne = double.Parse(Console.ReadLine());
            var numerTwo = double.Parse(Console.ReadLine());
            var eps = 0.000001;

            if (numberOne > numerTwo)
            {
                if(numberOne - numerTwo < eps)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                if (numerTwo - numberOne < eps)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            Console.ReadLine();
        }
    }
}
