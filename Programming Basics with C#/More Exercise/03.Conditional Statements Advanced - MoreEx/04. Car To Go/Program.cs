using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double rentPrice = 0;
            string clas = "";
            string typeOfCar = "";

            if (budget <= 100)
            {
                clas = "Economy class";
                switch (season)
                {
                    case"Summer":
                        typeOfCar = "Cabrio";
                        rentPrice = budget * 0.35;
                        break;
                    case"Winter":
                        typeOfCar = "Jeep";
                        rentPrice = budget * 0.65;
                        break;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                clas = "Compact class";
                switch (season)
                {
                    case "Summer":
                        typeOfCar = "Cabrio";
                        rentPrice = budget * 0.45;
                        break;
                    case "Winter":
                        typeOfCar = "Jeep";
                        rentPrice = budget * 0.80;
                        break;
                }
            }
            else
            {
                clas = "Luxury class";
                typeOfCar = "Jeep";
                rentPrice = 0.90 * budget;
            }

            Console.WriteLine(clas);
            Console.WriteLine($"{typeOfCar} - {rentPrice:f2}");
        }
    }
}
