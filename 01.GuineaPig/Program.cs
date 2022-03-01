using System;

namespace _01.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float food = float.Parse(Console.ReadLine());
            float hay = float.Parse(Console.ReadLine());
            float cover = float.Parse(Console.ReadLine());
            float weight = float.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                if(food <= 0 || hay <= 0 || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }

                food -= 0.300f;

                if (i % 2 == 0)
                {
                    hay -= food * 0.05f;
                }

                if(i % 3 == 0)
                {
                    cover -= weight * 0.333f;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:F2}, Hay: {hay:F2}, Cover: {cover:F2}.");
        }
    }
}
