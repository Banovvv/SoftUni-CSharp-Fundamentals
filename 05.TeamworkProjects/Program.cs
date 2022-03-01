using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        // 83 / 100
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] teamArgs = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string user = teamArgs[0];
                string teamName = teamArgs[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if(teams.Any(x=>x.Creator == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                Team currentTeam = new Team(teamName, user);

                teams.Add(currentTeam);

                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] args = command.Split(new string[] {"->"}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string user = args[0];
                string teamName = args[1];

                if(!teams.Any(x=> x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    command = Console.ReadLine();
                    continue;
                }

                Team currentTeam = teams.Where(x => x.TeamName == teamName).FirstOrDefault();

                if ((!currentTeam.IsTeamEmpty() && currentTeam.Members.Contains(user)) || currentTeam.Creator == user)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    command = Console.ReadLine();
                    continue;
                }

                currentTeam.AddMember(user);

                command = Console.ReadLine();
            }

            teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.TeamName).Where(x=>x.Members.Count > 0).ToList();

            foreach (Team team in teams)
            {
                if (!team.IsTeamEmpty())
                {
                    team.PrintTeam(); 
                }
            }

            List<Team> teamsToDisband = teams.Where(x => x.IsTeamEmpty()).ToList();

            Console.WriteLine("Teams to disband:");

            if (teamsToDisband.Count != 0)
            {
                foreach(Team team in teamsToDisband)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }
    }

    public class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public void AddMember(string user)
        {
            Members.Add(user);
        }

        public bool IsTeamEmpty()
        {
            return Members.Count == 0;
        }

        public void PrintTeam()
        {
            Console.WriteLine(TeamName);
            Console.WriteLine($"- {Creator}");
            foreach (string member in Members.OrderBy(x=> x))
            {
                Console.WriteLine($"-- {member}");
            }
        }
    }
}
