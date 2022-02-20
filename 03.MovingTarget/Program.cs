using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main()
        {
            List<int> targets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] args = command.Split();
                string action = args[0];

                if (action == "Shoot")
                {
                    Shoot(targets, args);
                }
                else if (action == "Add")
                {
                    Add(targets, args);
                }
                else if (action == "Strike")
                {
                    Strike(targets, args);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }

        static void Shoot(List<int> targets, string[] args)
        {
            int index = int.Parse(args[1]);
            int power = int.Parse(args[2]);


            if(index >= 0 && index < targets.Count)
            {
                targets[index] -= power;
            }

            if(targets[index] <= 0)
            {
                targets.RemoveAt(index);
            }
        }

        static void Add(List<int> targets, string[] args)
        {
            int index = int.Parse(args[1]);
            int value = int.Parse(args[2]);

            if(index < targets.Count)
            {
                targets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        static void Strike(List<int> targets, string[] args)
        {
            int index = int.Parse(args[1]);
            int radius = int.Parse(args[2]);

            int startIndex, endIndex;

            if(index - radius < 0)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            else
            {
                startIndex = index - radius;
            }

            if(radius + index > targets.Count)
            {
                Console.WriteLine("Strike missed!");
                return;
            }
            else
            {
                endIndex = radius + index;
            }
            
            targets.RemoveRange(startIndex, endIndex - startIndex + 1);
        }
    }
}
