using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    internal class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] args = Console.ReadLine().Split();
                string command = args[0];

                if (command == "register")
                {
                    Register(parkingLot, args);
                }
                else if (command == "unregister")
                {
                    Unregister(parkingLot, args);
                }
            }

            foreach(var lot in parkingLot)
            {
                Console.WriteLine($"{lot.Key} => {lot.Value}");
            }
        }

        public static void Register(Dictionary<string, string> parkingLot, string[] args)
        {
            string user = args[1];
            string plateNumber = args[2];

            if (parkingLot.ContainsKey(user))
            {
                Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
            }
            else
            {
                Console.WriteLine($"{user} registered {plateNumber} successfully");
                parkingLot.Add(user, plateNumber);
            }
        }

        public static void Unregister(Dictionary<string, string> parkingLot, string[] args)
        {
            string user = args[1];

            if (!parkingLot.ContainsKey(user))
            {
                Console.WriteLine($"ERROR: user {user} not found");
            }
            else
            {
                Console.WriteLine($"{user} unregistered successfully");
                parkingLot.Remove(user);
            }
        }
    }
}
