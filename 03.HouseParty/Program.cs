using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main()
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] args = Console.ReadLine().Split().ToArray();
                string name = args[0];
                bool isGoing = args.Length > 3 ? false : true;

                if (isGoing && !guests.Contains(name))
                {
                    guests.Add(name);
                }
                else if (isGoing && guests.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else if (!isGoing && guests.Contains(name))
                {
                    guests.Remove(name);
                }
                else if (!isGoing && !guests.Contains(name))
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
