using System;

namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main()
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            MultiplicationSign(one, two, three);
        }

        static void MultiplicationSign(int one, int two, int three)
        {
            int negative = 0;
            bool isZero = false;

            if(one == 0 || two == 0 || three == 0)
            {
                isZero = true;
            }

            if (one < 0)
            {
                negative++;
            }
            if (two < 0)
            {
                negative++;
            }
            if (three < 0)
            {
                negative++;
            }

            if (isZero)
            {
                Console.WriteLine("zero");
            }
            else if(negative == 0 || negative == 2)
            {
                Console.WriteLine("positive");
            }
            else if (negative == 1 || negative == 3)
            {
                Console.WriteLine("negative");
            }
        }
    }
}