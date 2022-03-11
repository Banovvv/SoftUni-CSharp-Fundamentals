using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    internal class Program
    {
        // 70/100
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, int> resources = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"motes", 0 },
                {"fragments", 0 }
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();

            var resourceAmountReached = string.Empty;

            while (!string.IsNullOrEmpty(input))
            {
                string[] args = input.Split();

                for (int i = 0; i < args.Count(); i += 2)
                {
                    int quantity = int.Parse(args[i]);
                    string resource = args[i + 1].ToLower();

                    string[] suitableResources = { "fragments", "shards", "motes" };

                    if (suitableResources.Contains(resource))
                    {
                        FillResources(resources, resource, quantity);
                    }
                    else
                    {
                        FillResources(junk, resource, quantity);
                    }

                    resourceAmountReached = resources.Where(x => x.Value >= 250).FirstOrDefault().Key;

                    if (resourceAmountReached != null)
                    {
                        if (resourceAmountReached == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            resources[resourceAmountReached] -= 250;
                            break;
                        }
                        else if (resourceAmountReached == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                            resources[resourceAmountReached] -= 250;
                            break;
                        }
                        else if (resourceAmountReached == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            resources[resourceAmountReached] -= 250;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        static void FillResources(Dictionary<string, int> resources, string resource, int quantity)
        {
            if (resources.ContainsKey(resource))
            {
                resources[resource] += quantity;
            }
            else
            {
                resources.Add(resource, quantity);
            }
        }
    }
}
