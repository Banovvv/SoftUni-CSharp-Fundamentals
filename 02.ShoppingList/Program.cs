using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    internal class Program
    {
        static void Main()
        {
            List<string> groceries = Console.ReadLine().Split('!').ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] args = command.Split();
                string action = args[0];

                if (action == "Urgent")
                {
                    Urgent(groceries, args);
                }
                else if (action == "Unnecessary")
                {
                    Unnecessary(groceries, args);
                }
                else if (action == "Correct")
                {
                    Correct(groceries, args);
                }
                else if (action == "Rearrange")
                {
                    Rearrange(groceries, args);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", groceries));
        }

        static void Urgent(List<string> groceries, string[] args)
        {
            string product = args[1];

            if (!groceries.Contains(product))
            {
                groceries.Insert(0, product);
            }
        }

        static void Unnecessary(List<string> groceries, string[] args)
        {
            string product = args[1];

            if (groceries.Contains(product))
            {
                groceries.Remove(product);
            }
        }

        static void Correct(List<string> groceries, string[] args)
        {
            string oldProduct = args[1];
            string newProduct = args[2];

            if (groceries.Contains(oldProduct))
            {
                int index = groceries.IndexOf(oldProduct);
                groceries.Remove(oldProduct);
                groceries.Insert(index, newProduct);
            }
        }

        static void Rearrange(List<string> groceries, string[] args)
        {
            string product = args[1];

            if (groceries.Contains(product))
            {
                groceries.Remove(product);
                groceries.Add(product);
            }
        }
    }
}
