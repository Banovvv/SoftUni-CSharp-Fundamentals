using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sumOfEvenDigits = GetSumOfEvenDigits(input);
            int sumOfOddnDigits = GetSumOfOddDigits(input);

            int result = GetMultipleOfEvenAndOdds(sumOfEvenDigits, sumOfOddnDigits);

            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int sumOfEven, int sumOfOdd)
        {
            return sumOfEven * sumOfOdd;
        }

        static int GetSumOfEvenDigits(int input)
        {
            int evenSum = 0;
            char[] charArray = Math.Abs(input).ToString().ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (int.Parse(charArray[i].ToString()) % 2 == 0)
                {
                    evenSum += int.Parse(charArray[i].ToString());
                }
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int input)
        {
            int oddSum = 0;
            char[] charArray = Math.Abs(input).ToString().ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (int.Parse(charArray[i].ToString()) % 2 != 0)
                {
                    oddSum += int.Parse(charArray[i].ToString());
                }
            }

            return oddSum;
        }

    }
}