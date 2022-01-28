using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());

            CharactersInRange(one, two);
        }

        static void CharactersInRange(char one, char two)
        {
            if(one > two)
            {
                for (int i = two + 1; i < one; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = one + 1; i < two; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}