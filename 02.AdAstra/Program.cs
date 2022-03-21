using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.AdAstra
{
    public class Program
    {
        static void Main()
        {
            List<Food> foodList = new List<Food>();

            string foodInfo = Console.ReadLine();

            string pattern = @"(\#|\|)(?<itemName>[A-z\s]+)\1(?<expirationDate>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]{1,5})\1";

            MatchCollection matches = Regex.Matches(foodInfo, pattern);

            foreach (Match match in matches)
            {
                string name = match.Groups["itemName"].Value;
                string expirationDate = match.Groups["expirationDate"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                foodList.Add(new Food(name, expirationDate, calories));
            }

            int days = foodList.Sum(x => x.Calories) / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Food food in foodList)
            {
                Console.WriteLine(food);
            }
        }
    }

    public class Food
    {
        public Food(string name, string expirationDate, int calories)
        {
            Name = name;
            ExpirationDate = expirationDate;
            Calories = calories;
        }
        public string Name { get; set; }
        public string ExpirationDate { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $"Item: {Name}, Best before: {ExpirationDate}, Nutrition: {Calories}";
        }
    }
}
