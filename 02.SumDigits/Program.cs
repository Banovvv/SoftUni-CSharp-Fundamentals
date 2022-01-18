using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string numberSting = number.ToString();
            int sum = 0;
            char[] charArray = new char[numberSting.Length];

            for (int i = 0; i < numberSting.Length; i++)
            {
                charArray[i] = numberSting[i];
                sum += int.Parse(charArray[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
