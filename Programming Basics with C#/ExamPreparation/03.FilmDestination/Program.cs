using System;

namespace _03.FilmDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Winter":
                    switch (destination)
                    {
                        case "Dubai":
                            price = 45000;
                            break;
                        case "Sofia":
                            price = 17000;
                            break;
                        case "London":
                            price = 24000;
                            break;
                    }
                    break;
                case "Summer":
                    switch (destination)
                    {
                        case "Dubai":
                            price = 40000;
                            break;
                        case "Sofia":
                            price = 12500;
                            break;
                        case "London":
                            price = 20250;
                            break;
                    }
                    break;
            }

            double finalPrice = price * days;

            if (destination == "Dubai")
            {
                finalPrice *= 0.70;
            }
            else if (destination == "Sofia")
            {
                finalPrice *= 1.25;
            }

            if (filmBudget >= finalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {filmBudget - finalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {finalPrice - filmBudget:f2} leva more!");
            }
        }
    }
}
