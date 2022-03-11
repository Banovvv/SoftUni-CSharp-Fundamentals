using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpeedRacing
{
    public class Program
    {
        static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carArgs = Console.ReadLine().Split();

                string model = carArgs[0];
                decimal fuelAmount = Convert.ToDecimal(carArgs[1]);
                decimal fuelCOnsumption = Convert.ToDecimal(carArgs[2]);

                cars.Add(new Car(model, fuelAmount, fuelCOnsumption));
            }

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] commandArgs = command.Split();
                string model = commandArgs[1];
                int distance = int.Parse(commandArgs[2]);

                Car currentCar = cars.Where(x=>x.Model == model).FirstOrDefault();

                currentCar.Drive(distance);

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }

    public class Car
    {
        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            DistanceTravelled = 0;
        }
        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelConsumption { get; set; }
        public int DistanceTravelled { get; set; }

        public void Drive(int distance)
        {
            if (FuelAmount - distance * FuelConsumption < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                DistanceTravelled += distance;
                FuelAmount -= distance * FuelConsumption;
            }
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {DistanceTravelled}";
        }
    }
}
