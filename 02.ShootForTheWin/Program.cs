using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            int targetsShot = 0;

            while (command != "End")
            {
                int targetIndex = int.Parse(command);

                if(targetIndex >= 0 && targetIndex < targets.Count)
                {
                    ShootTarget(targets, targetIndex);
                    targetsShot++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {targetsShot} -> {string.Join(" ", targets)}");
        }

        static void ShootTarget(List<int> targets, int targetIndex)
        {
            if(targets[targetIndex] == -1)
            {
                return;
            }

            int targetShot = targets[targetIndex];
            targets[targetIndex] = -1;

            for (int i = 0; i < targets.Count; i++)
            {
                if(targets[i] != -1 && targets[i] > targetShot)
                {
                    targets[i] -= targetShot;
                }
                else if (targets[i] != -1 && targets[i] <= targetShot)
                {
                    targets[i] += targetShot;
                }
            }
        }
    }
}
