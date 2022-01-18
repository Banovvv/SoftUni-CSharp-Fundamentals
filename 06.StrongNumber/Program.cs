using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string numberSting = number.ToString();
            int factorialNumber;
            int factorialSum = 1;
            int sum = 0;
            char[] charArray = new char[numberSting.Length];

            for (int i = 0; i < numberSting.Length; i++)
            {
                charArray[i] = numberSting[i];
                factorialNumber = int.Parse(charArray[i].ToString());

                for (int j = factorialNumber; j >= 1; j--)
                {
                    factorialSum *= j;
                }

                sum += factorialSum;
                factorialSum = 1;
            }

            if (sum == number)
            {

                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
