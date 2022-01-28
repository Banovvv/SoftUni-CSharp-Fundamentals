using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            TopNumber(range);
        }

        static void TopNumber(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                char[] number = i.ToString().ToCharArray();
                int sum = 0;
                bool hasOddNumber = false;

                for (int j = 0; j < number.Length; j++)
                {
                    sum += int.Parse(number[j].ToString());
                    if(int.Parse(number[j].ToString()) % 2 != 0)
                    {
                        hasOddNumber = true;
                    }
                }

                if (hasOddNumber && sum % 8 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
