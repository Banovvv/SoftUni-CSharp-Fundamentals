using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());
            int storrage = 0;
            int days = 0;

            while (yield >= 100)
            {
                storrage += yield;
                storrage -= 26;
                yield -= 10;
                days++;
            }
            if (yield < 100 && storrage != 0)
            {
                storrage -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(storrage);
        }
    }
}
