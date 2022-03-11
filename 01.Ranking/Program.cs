using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    public class Program
    {
        static void Main()
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string contestCommand = Console.ReadLine();

            while (contestCommand != "end of contests")
            {
                string[] args = contestCommand.Split(':');

                string contestName = args[0];
                string contestPass = args[1];

                contests.Add(contestName, contestPass);

                contestCommand = Console.ReadLine();
            }

            List<User> users = new List<User>();

            string participantCommand = Console.ReadLine();

            while (participantCommand != "end of submissions")
            {
                string[] args = participantCommand.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);

                string contest = args[0];
                string password = args[1];
                string user = args[2];
                int points = int.Parse(args[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == password)
                    {
                        var currentUser = users.Where(x => x.Name == user).FirstOrDefault();

                        if (currentUser != null)
                        {
                            if (currentUser.Contests.ContainsKey(contest))
                            {
                                if (currentUser.Contests[contest] < points)
                                {
                                    currentUser.Contests[contest] = points;
                                }
                            }
                            else
                            {
                                currentUser.Contests.Add(contest, points);
                            }
                        }
                        else
                        {
                            var contestKVP = new KeyValuePair<string, int>(contest, points);
                            users.Add(new User(user, contestKVP));
                        }
                    }
                }

                participantCommand = Console.ReadLine();
            }

            int bestScore = -1;
            User bestUser = new User();

            foreach (var user in users)
            {
                var currentScore = user.Contests.Sum(x => x.Value);

                if (currentScore > bestScore)
                {
                    bestScore = currentScore;
                    bestUser = user;
                }
            }

            Console.WriteLine($"Best candidate is {bestUser.Name} with total {bestScore} points.");
            Console.WriteLine("Ranking: ");
            users = users.OrderBy(x => x.Name).ToList();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
                foreach (var contest in user.Contests.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }

    public class User
    {
        public User()
        {

        }
        public User(string name, KeyValuePair<string, int> contest)
        {
            Name = name;
            Contests = new Dictionary<string, int>();
            Contests.Add(contest.Key, contest.Value);
        }
        public string Name { get; set; }
        public Dictionary<string, int> Contests { get; set; }

    }
}
