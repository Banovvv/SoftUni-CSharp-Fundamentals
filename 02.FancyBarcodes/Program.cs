using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string pattern = @"@#{1,}(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#{1,}";
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Product product = new Product(input);
                    Console.WriteLine($"Product group: {product.Group}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }

    public class Product
    {
        public Product(string barcode)
        {
            Barcode = barcode;
            Group = GetGroup(barcode);
        }
        public string Barcode { get; set; }
        public string Group { get; set; }

        public string GetGroup(string barcode)
        {
            char[] chars = barcode.Where(c => char.IsDigit(c)).ToArray();

            if (chars.Length > 0)
            {
                return string.Join("", chars);
            }
            else
            {
                return "00";
            }
        }
    }
}
