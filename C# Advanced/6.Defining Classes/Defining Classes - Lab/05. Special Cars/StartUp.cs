using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Special_Cars
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string firstInput = Console.ReadLine();
            while (firstInput != "No more tires")
            {
                string[] data = firstInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Tire[] currTires = new Tire[4]
                {
                    new Tire(int.Parse(data[0]),double.Parse(data[1])),
                    new Tire(int.Parse(data[2]),double.Parse(data[3])),
                    new Tire(int.Parse(data[4]),double.Parse(data[5])),
                    new Tire(int.Parse(data[6]),double.Parse(data[7]))
                };
                tires.Add(currTires);

                firstInput = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();
            while (secondInput != "Engines done")
            {
                string[] data = secondInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine currEngine = new Engine(int.Parse(data[0]), double.Parse(data[1]));
                engines.Add(currEngine);

                secondInput = Console.ReadLine();
            }

            string thirdInput = Console.ReadLine();
            while (thirdInput != "Show special")
            {
                string[] data = thirdInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = data[0];
                string model = data[1];
                int year = int.Parse(data[2]);
                double fuelQuantity = double.Parse(data[3]);
                double fuelConsumption = double.Parse(data[4]);
                int engineIndex = int.Parse(data[5]);
                int tiresIndex = int.Parse(data[6]);

                Car currCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(currCar);

                thirdInput = Console.ReadLine();
            }

            cars = cars.Where(c =>
                c.Year >= 2017 
                && c.Engine.HorsePower > 330 
                && c.Tires.Sum(y => y.Pressure) >= 9 
                &&
                c.Tires.Sum(y => y.Pressure) <= 10)
                .ToList();

            foreach (var car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
