using System;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main()
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int[] array = { one, two, three };
            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
