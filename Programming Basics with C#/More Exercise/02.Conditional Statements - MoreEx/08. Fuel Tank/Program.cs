using System;

namespace _08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double fuelInTank = double.Parse(Console.ReadLine());

            if (fuelInTank >= 25)
            {
                switch (typeOfFuel)
                {
                    case"Diesel":
                        Console.WriteLine($"You have enough diesel.");
                        break;
                    case"Gasoline":
                        Console.WriteLine($"You have enough gasoline.");
                        break;
                    case"Gas":
                        Console.WriteLine($"You have enough gas.");
                        break;
                    default:
                        Console.WriteLine("Invalid fuel!");
                        break;

                }
            }
            else
            {
                switch (typeOfFuel)
                {
                    case"Diesel":
                        Console.WriteLine($"Fill your tank with diesel!");
                        break;
                    case "Gasoline":
                        Console.WriteLine($"Fill your tank with gasoline!");
                        break;
                    case "Gas":
                        Console.WriteLine($"Fill your tank with gas!");
                        break;
                    default:
                        Console.WriteLine("Invalid fuel!");
                        break;
                }
            }

        }
    }
}
