using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main()
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            for (int i = 0; i < playerOne.Count; i++)
            {
                if(playerOne.Count == 0 || playerTwo.Count == 0)
                {
                    break;
                }

                if(playerOne[i] == playerTwo[i])
                {
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);
                }
                else if (playerOne[i] > playerTwo[i])
                {
                    playerOne.Add(playerOne[i]);
                    playerOne.Add(playerTwo[i]);
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);
                }
                else if (playerOne[i] < playerTwo[i])
                {
                    playerTwo.Add(playerTwo[i]);
                    playerTwo.Add(playerOne[i]);
                    playerOne.RemoveAt(i);
                    playerTwo.RemoveAt(i);
                }
            }

            if(playerOne.Count > 0)
            {
                Console.WriteLine($"First player wins!Sum: {playerOne.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins!Sum: {playerTwo.Sum()}");
            }
        }
    }
}
