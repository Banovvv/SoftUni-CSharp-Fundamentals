using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main()
        {
            List<int> neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int index = 0;

            while (command != "Love!")
            {
                string[] args = command.Split();
                int jumpLength = int.Parse(args[1]);
                index = index + jumpLength > neighborhood.Count ? 0 : index + jumpLength;
            }
        }

        static void Jump(List<int> neighborhood, int index, int jumpLength)
        {

        }
    }
}
