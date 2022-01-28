using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main()
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            FactorialDevision(one, two);
        }

        static void FactorialDevision(int one, int two)
        {
            double factorialOne = 1;

            while(one >= 1)
            {
                factorialOne *= one;
                one--;
            }

            double factorialTwo = 1;

            while (two >= 1)
            {
                factorialTwo *= two;
                two--;
            }

            Console.WriteLine($"{(factorialOne/factorialTwo):F2}");
        }
    }
}