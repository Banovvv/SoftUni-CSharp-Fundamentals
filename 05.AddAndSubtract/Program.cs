using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main()
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            int result = Subtract(Add(one, two), three);

            Console.WriteLine(result);
        }

        static int Add(int one, int two)
        {
            return one + two;
        }

        static int Subtract(int one, int two)
        {
            return one - two;
        }
    }
}