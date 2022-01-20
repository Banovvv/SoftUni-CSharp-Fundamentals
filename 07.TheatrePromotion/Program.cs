using System;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main()
        {
            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            int priceOfTicket = 0;

            switch (typeOfDay)
            {
                case "Weekday":
                    {
                        if (age >= 0 && age <= 18)
                        {
                            priceOfTicket = 12;
                            
                        }
                        else if (age > 18 && age <= 64)
                        {
                            priceOfTicket = 18;
                        }
                        else if (age > 64 && age <= 122)
                        {
                            priceOfTicket = 12;
                        }
                        break;
                    }
                case "Weekend":
                    {
                        if (age >= 0 && age <= 18)
                        {
                            priceOfTicket = 15;
                        }
                        else if (age > 18 && age <= 64)
                        {
                            priceOfTicket = 20;
                        }
                        else if (age > 64 && age <= 122)
                        {
                            priceOfTicket = 15;
                        }
                        break;
                    }
                case "Holiday":
                    {
                        if (age >= 0 && age <= 18)
                        {
                            priceOfTicket = 5;
                        }
                        else if (age > 18 && age <= 64)
                        {
                            priceOfTicket = 12;
                        }
                        else if (age > 64 && age <= 122)
                        {
                            priceOfTicket = 10;
                        }
                        break;
                    }
            }

            if (priceOfTicket != 0)
            {
                Console.WriteLine($"{priceOfTicket}$"); 
            }
            else
            {
                Console.WriteLine($"Error!");
            }
        }
    }
}
