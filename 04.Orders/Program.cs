using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Orders
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Amount> products = new Dictionary<string, Amount>();

            string commnad = Console.ReadLine();

            while (commnad != "buy")
            {
                string[] args = commnad.Split();

                string name =  args[0];
                decimal price = Convert.ToDecimal(args[1]);
                int quantity = Convert.ToInt32(args[2]);

                if (products.ContainsKey(name))
                {
                    products.Where(x => x.Key == name).ToList().ForEach(x => x.Value.Quantity += quantity);
                    products.Where(x => x.Key == name).ToList().ForEach(x => x.Value.Price = price);
                }
                else
                {
                    products.Add(name, new Amount(price, quantity));
                }

                commnad = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value.Quantity * product.Value.Price):F2}");
            }
        }
    }

    public class Amount
    {
        public Amount(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
