using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            SmallestInteger(numberOne, numberTwo, numberThree);
        }

        static void SmallestInteger(int one, int two, int three)
        {
            if (one <= two && one <= three)
            {
                Console.WriteLine(one);
            }
            else if (two <= one && two <= three)
            {
                Console.WriteLine(two);
            }
            else if (three <= one && three <= two)
            {
                Console.WriteLine(three);
            }
        }
    }
}