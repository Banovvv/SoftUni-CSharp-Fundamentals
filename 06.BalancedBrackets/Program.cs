using System;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            int bracketCount = 0;
            bool balanced = true;
            string previousBracket = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine();
                if (input == "(" || input == ")")
                {
                    if(previousBracket == input)
                    {
                        balanced = false;
                        break;
                    }
                    else
                    {
                        previousBracket = input;
                        bracketCount++;
                    }
                }
            }
            Console.WriteLine($"{(bracketCount % 2 == 0 && balanced ? "BALANCED" : "UNBALANCED")}");
        }
    }
}
