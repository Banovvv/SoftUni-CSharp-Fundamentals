using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    internal class Program
    {
        // 91/100
        static void Main()
        {
            Dictionary<string, List<Participant>> judge = new Dictionary<string, List<Participant>>();

            string command = Console.ReadLine();

            while (command != "no more time")
            {
                string[] args = command.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string userName = args[0].Trim();
                string contest = args[1].Trim();
                int points = int.Parse(args[2].Trim());

                if (judge.ContainsKey(contest))
                {
                    var currentUser = judge[contest].FirstOrDefault(x => x.Name == userName);

                    if (currentUser != null)
                    {
                        int currentScore = currentUser.Score;
                        if (currentScore < points)
                        {
                            currentUser.Score = points;
                        }
                    }
                    else
                    {
                        judge[contest].Add(new Participant(userName, points));
                    }
                }
                else
                {
                    List<Participant> userData = new List<Participant>();
                    Participant participant = new Participant(userName, points);
                    userData.Add(participant);

                    judge.Add(contest, userData);
                }

                command = Console.ReadLine();
            }

            Dictionary<string, int> individualScore = new Dictionary<string, int>();

            foreach (var contest in judge)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
                int count = 1;

                var users = contest.Value;

                foreach (var user in users.ToList().OrderByDescending(x=>x.Score).ThenBy(x=>x.Name))
                {
                    Console.WriteLine($"{count}. {user.Name} <::> {user.Score}");
                    count++;

                    if (individualScore.ContainsKey(user.Name))
                    {
                        individualScore[user.Name] += user.Score;
                    }
                    else
                    {
                        individualScore.Add(user.Name, user.Score);
                    }
                }
            }

            Console.WriteLine("Individual standings:");
            int counter = 1;

            foreach (var user in individualScore.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{counter}. {user.Key} -> {user.Value}");
                counter++;
            }
        }

    }

    public class Participant
    {
        public Participant(string participantName, int score)
        {
            Name = participantName;
            Score = score;
        }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
