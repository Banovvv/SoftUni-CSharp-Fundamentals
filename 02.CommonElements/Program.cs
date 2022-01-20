using System;
using System.Text;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main()
        {
            var stringOne = Console.ReadLine();
            var stringTwo = Console.ReadLine();
            string[] arrayTwo = stringTwo.Split(' ');
            StringBuilder commonStrings = new StringBuilder();

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                if (stringOne.Contains(arrayTwo[i]))
                {
                    if (i == arrayTwo.Length - 1)
                    {
                        commonStrings.Append(arrayTwo[i]); 
                    }
                    else
                    {
                        commonStrings.Append($"{arrayTwo[i]} ");
                    }
                }
            }

            Console.WriteLine(commonStrings);
        }
    }
}
