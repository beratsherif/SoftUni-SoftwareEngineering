using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherManCount = int.Parse(Console.ReadLine());

            double total = 0;

            switch (season)
            {
                case "Spring":
                    total = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    total = 4200;
                    break;
                case "Winter":
                    total = 2600;
                    break;
            }
            if (fisherManCount <= 6)
            {
                total *= 0.90;
            }
            else if (fisherManCount >= 7 && fisherManCount <= 11)
            {
                total *= 0.85;
            }
            else
            {
                total *= 0.75;
            }

            if (fisherManCount % 2 == 0 && season != "Autumn")
            {
                total *= 0.95;
            }

            double difference = Math.Abs(budget - total);

            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
