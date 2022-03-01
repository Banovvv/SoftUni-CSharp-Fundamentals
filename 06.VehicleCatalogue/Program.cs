using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();

                string rawType = commandArgs[0];
                string type = rawType.First().ToString().ToUpper() + rawType.Substring(1);
                string model = commandArgs[1];
                string color = commandArgs[2];
                int horsePower = int.Parse(commandArgs[3]);

                Vehicle currentVehicle = new Vehicle(type, model, color, horsePower);

                vehicles.Add(currentVehicle);

                command = Console.ReadLine();
            }

            string vehicleInfo = Console.ReadLine();

            while (vehicleInfo != "Close the Catalogue")
            {
                Vehicle currentVehicle = vehicles.Where(x => x.Model == vehicleInfo).FirstOrDefault();

                Console.WriteLine(currentVehicle);

                vehicleInfo = Console.ReadLine();
            }

            double carAvrgHorsePower = 0;
            double truckAvrgHorsePower = 0;

            if (vehicles.Where(x => x.Type == "Car").Count() > 0)
            {
                carAvrgHorsePower = vehicles.Where(x => x.Type == "Car").Average(y => y.HorsePower);
            }
            if (vehicles.Where(x => x.Type == "Truck").Count() > 0)
            {
                truckAvrgHorsePower = vehicles.Where(x => x.Type == "Truck").Average(y => y.HorsePower);
            }

            Console.WriteLine($"Cars have average horsepower of: {carAvrgHorsePower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAvrgHorsePower:F2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
        }
    }
}
