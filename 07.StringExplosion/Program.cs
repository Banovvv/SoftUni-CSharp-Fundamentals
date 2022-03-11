using System;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string result = Explode(text);

            Console.WriteLine(result);
        }

        static string Explode(string text)
        {
            int bomb = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (bomb > 0 && text[i] != '>')
                {
                    text = text.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else if (text[i] == '>')
                {
                    bomb += int.Parse(text[i + 1].ToString());
                }
            }

            return text;
        }
    }
}
