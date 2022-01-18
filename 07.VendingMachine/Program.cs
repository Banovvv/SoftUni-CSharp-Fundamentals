using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            double sum = 0;
            double price;
            string input;
            string product;
            bool start = false;
            bool end = false;
            while (!start)
            {
                input = Console.ReadLine();

                if (!input.Equals("Start"))
                {
                    number = double.Parse(input);

                    if (number == 0.1 | number == 0.2 | number == 0.5 | number == 1 | number == 2)
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {number}");
                    }
                }
                else
                {
                    start = true;
                }
            }

            while (!end)
            {
                product = Console.ReadLine();
                if (!product.Equals("End"))
                {
                    switch (product)
                    {
                        case "Nuts":
                            {
                                price = 2.0;
                                if (sum - price >= 0)
                                {
                                    Console.WriteLine($"Purchased {product.ToLower()}");
                                    sum -= price;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                            }
                        case "Water":
                            {
                                price = 0.7;
                                if (sum - price >= 0)
                                {
                                    Console.WriteLine($"Purchased {product.ToLower()}");
                                    sum -= price;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                            }
                        case "Crisps":
                            {
                                price = 1.5;
                                if (sum - price >= 0)
                                {
                                    Console.WriteLine($"Purchased {product.ToLower()}");
                                    sum -= price;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                            }
                        case "Soda":
                            {
                                price = 0.8;
                                if (sum - price >= 0)
                                {
                                    Console.WriteLine($"Purchased {product.ToLower()}");
                                    sum -= price;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                            }
                        case "Coke":
                            {
                                price = 1.0;
                                if (sum - price >= 0)
                                {
                                    Console.WriteLine($"Purchased {product.ToLower()}");
                                    sum -= price;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, not enough money");
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid product");
                                break;
                            }
                    }
                }
                else
                {
                    end = true;
                }
            }

            Console.WriteLine($"Change: {sum:N2}");
        }
    }
}
