using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (input < 1 || input > weekDays.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(weekDays[input - 1]);
            }
        }
    }
}