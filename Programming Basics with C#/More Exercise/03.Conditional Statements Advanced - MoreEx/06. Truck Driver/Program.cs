using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometersFor1Month = double.Parse(Console.ReadLine());
            double priceFor1Kilometer = 0;
            double totalPrice = 0;


            if (kilometersFor1Month <= 5000)
            {
                switch (season)
                {
                    case"Spring":
                    case"Autumn":
                        priceFor1Kilometer = 0.75;
                        break;
                    case"Summer":
                        priceFor1Kilometer = 0.90;
                        break;
                    case"Winter":
                        priceFor1Kilometer = 1.05;
                        break;
                }
            }
            else if (kilometersFor1Month > 5000 && kilometersFor1Month <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        priceFor1Kilometer = 0.95;
                        break;
                    case "Summer":
                        priceFor1Kilometer = 1.10;
                        break;
                    case "Winter":
                        priceFor1Kilometer = 1.25;
                        break;
                }

            }
            else if (kilometersFor1Month > 10000 && kilometersFor1Month <= 20000)
            {
                priceFor1Kilometer = 1.45;
            }

            totalPrice = (kilometersFor1Month * priceFor1Kilometer) * 4;
            double finalPrice = totalPrice * 0.90;

            Console.WriteLine($"{finalPrice:f2}");

        }
    }
}
