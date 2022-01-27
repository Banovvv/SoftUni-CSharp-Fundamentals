using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double numberAtPower = NumberAtPower(number, power);

            Console.WriteLine(numberAtPower);
        }

        static double NumberAtPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}