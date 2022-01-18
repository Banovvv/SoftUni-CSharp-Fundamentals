using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            float money = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float lightsaberPrice = float.Parse(Console.ReadLine());
            float robePrice = float.Parse(Console.ReadLine());
            float beltPrice = float.Parse(Console.ReadLine());

            int lightsaberCount = (int)Math.Ceiling(students * 1.10);
            int beltCount = students;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    beltCount--;
                }
            }

            float sum = 0;

            sum += lightsaberPrice * lightsaberCount + robePrice * students + beltPrice * beltCount;

            if (money >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(sum - money):F2}lv more.");
            }
        }
    }
}
