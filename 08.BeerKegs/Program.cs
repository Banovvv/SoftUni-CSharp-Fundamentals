using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string model = string.Empty;
            float radius;
            int height;
            string largestModel = string.Empty;
            double volume = 0;
            double largestVolume = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                model = Console.ReadLine();
                radius = float.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                volume = (Math.PI * radius * radius * height);

                if (volume > largestVolume)
                {
                    largestModel = model;
                    largestVolume = volume;
                }

            }

            Console.WriteLine(largestModel);
        }
    }
}
