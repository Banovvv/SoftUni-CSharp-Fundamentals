using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TrainLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonMaxCpacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] args = command.Split();

                if(args.Length == 1)
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passengersToAdd = int.Parse(args[0]);

                        if(passengersToAdd + wagons[i] <= wagonMaxCpacity)
                        {
                            wagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }
                else
                {
                    int wagonToAdd = int.Parse(args[1]);
                    wagons.Add(wagonToAdd);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
