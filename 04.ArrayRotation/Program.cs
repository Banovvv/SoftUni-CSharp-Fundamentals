using System;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main()
        {
            var inputArray = Console.ReadLine();
            var rotations = int.Parse(Console.ReadLine());
            string[] array = inputArray.Split(' ');
            string temp = string.Empty;

            // TODO: Complete this one
            for (int i = 1; i <= rotations; i++)
            {
                temp = array[array.Length - i];
                array[array.Length - i] = array[0];
                array[0] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.ReadLine();
        }
    }
}
