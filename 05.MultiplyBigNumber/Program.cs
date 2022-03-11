using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            // Multiplication by 0
            if (multiplier == 0)
            {
                Console.WriteLine(multiplier);
                return;
            }

            string result = Multiply(number, multiplier);

            Console.WriteLine(result);
        }

        static string Multiply(string number, int multiplier)
        {
            StringBuilder result = new StringBuilder();

            int caryOver = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentProduct = int.Parse(number[i].ToString()) * multiplier;
                int firstDigit = currentProduct / 10;
                int lastDigit = currentProduct % 10;

                if (lastDigit + caryOver > 9)
                {
                    int biggerCarryOver = lastDigit + caryOver;
                    result.Insert(0, biggerCarryOver % 10);
                    caryOver = firstDigit + (biggerCarryOver / 10);
                    continue;
                }
                else
                {
                    result.Insert(0, lastDigit + caryOver);
                }

                caryOver = firstDigit;
            }

            // Adding digit at the start if the carried over number is not 0
            if (caryOver != 0)
            {
                result.Insert(0, caryOver);
            }

            return result.ToString();
        }
    }
}
