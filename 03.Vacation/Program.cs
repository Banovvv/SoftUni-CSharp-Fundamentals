using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main()
        {
            double totalPrice = 0;
            double individualPrice = 0;
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            switch (groupType)
            {
                case "Students":
                    {
                        switch (day)
                        {
                            case "Friday": individualPrice = 8.45; break;
                            case "Saturday": individualPrice = 9.80; break;
                            case "Sunday": individualPrice = 10.46; break;
                        }

                        if (peopleCount >= 30)
                        {
                            totalPrice = (peopleCount * individualPrice) * 0.85;
                        }
                        else
                        {
                            totalPrice = peopleCount * individualPrice;
                        }
                        break;
                    }
                case "Business":
                    {
                        switch (day)
                        {
                            case "Friday": individualPrice = 10.90; break;
                            case "Saturday": individualPrice = 15.60; break;
                            case "Sunday": individualPrice = 16.00; break;
                        }

                        if (peopleCount >= 100)
                        {
                            totalPrice = (peopleCount - 10) * individualPrice;
                        }
                        else
                        {
                            totalPrice = peopleCount * individualPrice;
                        }
                        break;
                    }
                case "Regular":
                    {
                        switch (day)
                        {
                            case "Friday": individualPrice = 15.00;  break;
                            case "Saturday": individualPrice = 20.00; break;
                            case "Sunday": individualPrice = 22.50; break;
                        }

                        if (peopleCount >= 10 && peopleCount <= 20)
                        {
                            totalPrice = (peopleCount * individualPrice) * 0.95;
                        }
                        else
                        {
                            totalPrice = peopleCount * individualPrice;
                        }
                        break;
                    }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
