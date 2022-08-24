using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehichle> vehichles = new List<Vehichle>();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] theInput = command.Split();

                VehichleType vehichleType;
                bool isVehichleTypeParsSuccesful = Enum.TryParse(theInput[0], true, out vehichleType);

                if (isVehichleTypeParsSuccesful)
                {
                    string vehichleModel = theInput[1];
                    string vehichleColor = theInput[2];
                    int vehichleHorsePower = int.Parse(theInput[3]);

                    var currVehichle = new Vehichle(vehichleType, vehichleModel, vehichleColor, vehichleHorsePower);
                    vehichles.Add(currVehichle);
                }
            }

            while (true)
            {
                string theLastInput = Console.ReadLine();

                if (theLastInput == "Close the Catalogue")
                {
                    break;
                }

                Vehichle desiredVehichel = vehichles.FirstOrDefault(vehichle => vehichle.Model == theLastInput);

                Console.WriteLine(desiredVehichel);
            }

            List<Vehichle> cars = vehichles.Where(vehicle => vehicle.Type == VehichleType.Car).ToList();
            List<Vehichle> trucks = vehichles.Where(vehicle => vehicle.Type == VehichleType.Truck).ToList();

            double carsAverageHP = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            double trucksAverageHP = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHP:f2}.");
        }
    }

    enum VehichleType
    {
        Car,
        Truck
    }
    class Vehichle
    {
        public Vehichle(VehichleType type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public VehichleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}
