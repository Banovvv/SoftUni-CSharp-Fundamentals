using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main()
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] names = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                char[] name = Console.ReadLine().ToCharArray();
                string vowels = "AEIOUaeiou";
                for (int j = 0; j < name.Length; j++)
                {
                    if (vowels.Contains(name[j]))
                    {
                        names[i] += name[j] * name.Length;
                    }
                    else
                    {
                        names[i] += name[j] / name.Length;
                    }
                }
            }

            Array.Sort(names);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}