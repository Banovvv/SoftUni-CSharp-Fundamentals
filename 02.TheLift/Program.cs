using System;
using System.Linq;

namespace _02.TheLift
{
    internal class Program
    {
        static void Main()
        {
            var queue = int.Parse(Console.ReadLine());
            string[] wagons = Console.ReadLine().Split().ToArray();
            int[] wagonsCapacity = new int[wagons.Length];

            for (int i = 0; i < wagons.Length; i++)
            {
                wagonsCapacity[i] = int.Parse(wagons[i]);

                while(wagonsCapacity[i] < 4 && queue != 0)
                {
                    if (queue > 0)
                    {
                        queue--;
                        wagonsCapacity[i]++; 
                    }
                }
            }

            if(wagonsCapacity.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagonsCapacity));
            }
            else if(queue > 0)
            {
                Console.WriteLine($"There isn't enough space! {queue} people in a queue!");
                Console.WriteLine(string.Join(" ", wagonsCapacity));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagonsCapacity));
            }
        }
    }
}
