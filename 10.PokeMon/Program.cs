using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main()
        {
            int initialPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokePower = initialPokePower;
            int pokes = 0;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                pokes++;
                if (pokePower == initialPokePower * 0.5 && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokes);
        }
    }
}
