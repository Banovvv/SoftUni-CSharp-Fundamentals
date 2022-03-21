using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            string command = Console.ReadLine();

            while (command != "end of shift")
            {
                ProcessOrder(customers, command);

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {(customers.Sum(x => x.TotalPrice)):F2}");
        }

        static void ProcessOrder(List<Customer> customers, string command)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(command);

            if (match.Success)
            {
                string name = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int quantity = int.Parse(match.Groups["quantity"].Value);
                decimal price = decimal.Parse(match.Groups["price"].Value);

                Customer currentCustomer = new Customer(name, product, quantity, price);

                customers.Add(currentCustomer);

                Console.WriteLine($"{currentCustomer.Name}: {currentCustomer.Product} - {currentCustomer.TotalPrice:F2}");
            }
        }
    }

    public class Customer
    {
        public Customer(string name, string product, int quantity, decimal price)
        {
            Name = name;
            Product = product;
            Quantity = quantity;
            Price = price;
            TotalPrice = Quantity * Price;
        }
        public string Name { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
