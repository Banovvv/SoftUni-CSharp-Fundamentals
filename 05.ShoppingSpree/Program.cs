using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShoppingSpree
{
    public class Program
    {
        static void Main()
        {
            string[] allPeople = Console.ReadLine().Split(';');
            string[] allProducts = Console.ReadLine().Split(';');

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            foreach (string person in allPeople)
            {
                string[] args = person.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                string name = args[0];
                decimal money = decimal.Parse(args[1]);

                people.Add(new Person(name, money));
            }

            foreach (string product in allProducts)
            {
                if (product.Length < 1)
                {
                    continue;
                }

                string[] args = product.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                string name = args[0];
                decimal price = decimal.Parse(args[1]);

                products.Add(new Product(name, price));
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] args = command.Split();

                string name = args[0];
                string product = args[1];

                Person currentPerson = people.Where(x=>x.Name == name).First();
                Product currentProduct = products.Where(x => x.Name == product).First();

                currentPerson.Buy(currentProduct);

                command = Console.ReadLine();
            }

            foreach(Person person in people)
            {
                person.Print();
            }
        }
    }

    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            ShoppingBag = new List<Product>();
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> ShoppingBag { get; set; }

        public void Buy(Product product)
        {
            if(Money - product.Price >= 0)
            {
                ShoppingBag.Add(product);
                Money -= product.Price;
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }

        public bool HasBougthProducts()
        {
            return ShoppingBag.Count > 0 ? true : false;
        }

        public void Print()
        {
            if (HasBougthProducts())
            {
                List<string> productsBougth = new List<string>();
                foreach (var product in ShoppingBag)
                {
                    productsBougth.Add(product.Name);
                }
                Console.WriteLine($"{Name} - {string.Join(", ", productsBougth)}");
            }
            else
            {
                Console.WriteLine($"{Name} - Nothing bought");
            }
        }
    }

    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
