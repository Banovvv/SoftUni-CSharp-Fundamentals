using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float monitorPrice = float.Parse(Console.ReadLine());
            int keyboardTrashed = 0;

            float rageExpenses = 0;

            while (lostGames > 0)
            {
                if (lostGames % 3 == 0 && lostGames % 2 == 0)
                {
                    keyboardTrashed++;
                    rageExpenses += mousePrice + headsetPrice + keyboardPrice;
                    if (keyboardTrashed % 2 == 0)
                    {
                        rageExpenses += monitorPrice;
                    }
                }
                else if (lostGames % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }
                else if (lostGames % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }

                lostGames--;
            }

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
