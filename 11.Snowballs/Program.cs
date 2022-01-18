using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main()
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int snowballSnowTemp = -1;
            int snowballTimeTemp = -1;
            int snowballQualityTemp = -1;
            BigInteger snowballValue = 0;
            BigInteger snowballValueTemp = -1;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue >= snowballValueTemp)
                {
                    snowballValueTemp = snowballValue;
                    snowballSnowTemp = snowballSnow;
                    snowballTimeTemp = snowballTime;
                    snowballQualityTemp = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowTemp} : {snowballTimeTemp} = {snowballValueTemp} ({snowballQualityTemp})");
        }
    }
}
