using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string command = Console.ReadLine();

            while (command != "Purchase")
            {
                string pattern = @">>(?<product>[A-Za-z]+)<<(?<price>[0-9]+(\.|)[0-9]*)!(?<quantity>[0-9]{1,})\b";
                Regex regex = new Regex(pattern);

                Match match = regex.Match(command);

                if (match.Success)
                {
                    string name = match.Groups["product"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    products.Add(new Product(name, price, quantity));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
            }

            decimal totalCosts = products.Sum(x => x.TotalPrice);
            Console.WriteLine($"Total money spend: {totalCosts:F2}");
        }
    }

    public class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            TotalPrice = Price * Quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
