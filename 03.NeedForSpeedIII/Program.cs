using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeedIII
{
    public class Program
    {
        static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carArgs = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string name = carArgs[0];
                int mileage = int.Parse(carArgs[1]);
                int fuel = int.Parse(carArgs[2]);

                cars.Add(new Car(name, mileage, fuel));
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                string currentCarName = commandArgs[1];

                Car currentCar = cars.Where(x => x.Name == currentCarName).First();

                if (action == "Drive")
                {
                    int distance = int.Parse(commandArgs[2]);
                    int fuel = int.Parse(commandArgs[3]);

                    currentCar.Drive(distance, fuel);

                    if (currentCar.Mileage > 100000)
                    {
                        Console.WriteLine($"Time to sell the {currentCar.Name}!");
                        cars.Remove(currentCar);
                    }
                }
                else if (action == "Refuel")
                {
                    int fuel = int.Parse(commandArgs[2]);

                    currentCar.Refuel(fuel);
                }
                else if (action == "Revert")
                {
                    int kilometers = int.Parse(commandArgs[2]);

                    currentCar.Revert(kilometers);
                }

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
        public Car(string name, int mileage, int fuel)
        {
            Name = name;
            Mileage = mileage;
            Fuel = fuel;
        }
        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public void Drive(int distance, int fuel)
        {
            if (Fuel - fuel < 0)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                Console.WriteLine($"{Name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                Fuel -= fuel;
                Mileage += distance;
            }
        }

        public void Refuel(int fuel)
        {
            if (Fuel + fuel <= 75)
            {
                Console.WriteLine($"{Name} refueled with {fuel} liters");
                Fuel += fuel;
            }
            else
            {
                int amountFilled = 75 - Fuel;
                Fuel = 75;
                Console.WriteLine($"{Name} refueled with {amountFilled} liters");
            }
        }

        public void Revert(int amountReverted)
        {            
            Mileage = Mileage - amountReverted < 10000 ? 10000 : Mileage - amountReverted;
            if(Mileage > 10000)
            {
                Console.WriteLine($"{Name} mileage decreased by {amountReverted} kilometers");
            }
        }

        public override string ToString()
        {
            return $"{Name} -> Mileage: {Mileage} kms, Fuel in the tank: {Fuel} lt.";
        }
    }
}
