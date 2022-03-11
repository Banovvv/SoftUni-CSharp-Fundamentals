using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBAChallenger
{
    public class Program
    {
        static void Main()
        {
            List<Player> players = new List<Player>();

            string command = Console.ReadLine();

            while (command != "Season end")
            {
                if (command.Contains("->"))
                {
                    AddPlayerOrPosition(players, command);
                }
                else
                {
                    Duel(players, command);
                }

                command = Console.ReadLine();
            }

            players = players.OrderByDescending(x => x.Ranking.Sum(y => y.Value)).ThenBy(x => x.Name).ToList();

            foreach (Player player in players)
            {
                player.TotalPoints = player.GetTotalPoints(player.Ranking);
                player.Print();

            }
        }

        static void AddPlayerOrPosition(List<Player> players, string command)
        {
            string[] args = command.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

            string player = args[0].Trim();
            string position = args[1].Trim();
            int ranking = int.Parse(args[2].Trim());

            var currentPlayer = players.Where(x => x.Name == player).FirstOrDefault();

            if (currentPlayer != null)
            {
                // Making sure the Ranking does not already contain the position
                if (!currentPlayer.Ranking.ContainsKey(position))
                {
                    currentPlayer.Ranking.Add(position, ranking);
                }
            }
            else
            {
                players.Add(new Player(player, position, ranking));
            }
        }

        static void Duel(List<Player> players, string command)
        {
            string[] args = command.Split(new string[] { "vs" }, StringSplitOptions.RemoveEmptyEntries);

            // Getting Player objects for each player
            Player playerOne = players.Where(x => x.Name == args[0].Trim()).FirstOrDefault();
            Player playerTwo = players.Where(x => x.Name == args[1].Trim()).FirstOrDefault();

            if (playerOne != null && playerTwo != null)
            {
                List<string> matchingPositions = playerOne.Ranking.Keys.ToList().Intersect(playerTwo.Ranking.Keys.ToList()).ToList();
                if (matchingPositions.Any())
                {
                    int playerOneRank = playerOne.Ranking.First(x => x.Key == matchingPositions[0]).Value;
                    int playerTwoRank = playerTwo.Ranking.First(x => x.Key == matchingPositions[0]).Value;

                    if (playerOneRank > playerTwoRank)
                    {
                        players.Remove(playerTwo);
                    }
                    else if (playerOneRank < playerTwoRank)
                    {
                        players.Remove(playerOne);
                    }
                }
            }
        }
    }

    public class Player
    {
        public Player(string name, string position, int ranking)
        {
            Name = name;
            Ranking = new Dictionary<string, int>
            {
                { position, ranking }
            };
        }
        public string Name { get; set; }
        public Dictionary<string, int> Ranking { get; set; }
        public int TotalPoints { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name}: {TotalPoints} skill");

            foreach (var kvp in Ranking.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($" - {kvp.Key} <::> {kvp.Value}");
            }
        }
        public int GetTotalPoints(Dictionary<string, int> ranking)
        {
            return ranking.Sum(x => x.Value);
        }
    }
}
