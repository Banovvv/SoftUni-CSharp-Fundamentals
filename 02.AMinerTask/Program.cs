using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main()
        {
            bool flag = false;

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (!flag)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    flag = true;
                    continue;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
            }

            foreach (KeyValuePair<string, int> kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
