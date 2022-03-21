using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<Competitor> competitors = new List<Competitor>();

            string command = Console.ReadLine();

            while (command != "end of race")
            {
                string name = GetName(command);
                int distance = GetDistance(command);

                if (names.Contains(name))
                {
                    Competitor currentCompetitor = competitors.FirstOrDefault(x => x.Name == name);

                    // If the competitor exists, add new distance to Distance
                    if (currentCompetitor != null)
                    {
                        currentCompetitor.Distance += distance;
                    }
                    // Add new competior
                    else
                    {
                        competitors.Add(new Competitor(name, distance));
                    }
                }

                command = Console.ReadLine();
            }

            PrintTopCompetitors(competitors);
        }

        public static void PrintTopCompetitors(List<Competitor> competitors)
        {
            competitors = competitors.OrderByDescending(x => x.Distance).ToList();
            Console.WriteLine($"1st place: {competitors[0].Name}");
            Console.WriteLine($"2nd place: {competitors[1].Name}");
            Console.WriteLine($"3rd place: {competitors[2].Name}");
        }
        public static string GetName(string command)
        {
            string namePattern = @"(?<name>[A-Za-z]{1,})";
            MatchCollection nameMatches = Regex.Matches(command, namePattern);
            string name = string.Empty;

            foreach (Match match in nameMatches)
            {
                name += match.Value;
            }

            return name;
        }

        public static int GetDistance(string command)
        {
            string distancePattern = @"(?<distance>[0-9])";
            MatchCollection distanceMatches = Regex.Matches(command, distancePattern);
            int distance = 0;

            foreach (Match match in distanceMatches)
            {
                distance += int.Parse(match.Value);
            }

            return distance;
        }
    }

    public class Competitor
    {
        public Competitor(string name, int distance)
        {
            Name = name;
            Distance = distance;
        }
        public string Name { get; set; }
        public int Distance { get; set; }
    }
}
