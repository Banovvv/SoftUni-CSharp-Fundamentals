using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    public class Program
    {
        static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] args = Console.ReadLine().Split();
                string model = args[0];
                int speed = int.Parse(args[1]);
                int power = int.Parse(args[2]);
                int weight = int.Parse(args[3]);
                string type = args[4];

                cars.Add(new Car(model, speed, power, weight, type));
            }

            string cargoType = Console.ReadLine();

            List<Car> carsToPrint = new List<Car>();

            if(cargoType == "fragile")
            {
                carsToPrint = cars.Where(car => car.CarCargo.CargoType == cargoType && car.CarCargo.CargoWeight < 1000).ToList();
            }
            else if(cargoType == "flamable")
            {
                carsToPrint = cars.Where(car => car.CarCargo.CargoType == cargoType && car.CarEngine.EnginePower > 250).ToList();
            }

            foreach (var car in carsToPrint)
            {
                Console.WriteLine(car.Model);
            }
        }
    }

    public class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            CarEngine = new Engine(speed, power);
            CarCargo = new Cargo(weight, type);
        }

        public string Model { get; set; }
        public Engine CarEngine { get; set; }
        public Cargo CarCargo { get; set; }

        public class Engine
        {
            public Engine(int speed, int power)
            {
                EngineSpeed = speed;
                EnginePower = power;
            }
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
        }

        public class Cargo
        {
            public Cargo(int weight, string type)
            {
                CargoWeight = weight;
                CargoType = type;
            }
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }
        }
    }
}
