using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            const double juniorsTrail = 5.50;
            const double juniorsCrossCountry = 8;
            const double juniorsDownhill = 12.25;
            const double juniorsRoad = 20;
            const double seniorsTrail = 7;
            const double seniorsCrossCountry = 9.50;
            const double seniorsDownhill = 13.75;
            const double seniorsRoad = 21.50;

            int countJunior = int.Parse(Console.ReadLine());
            int countSeniors = int.Parse(Console.ReadLine());
            string typeOfTerain = Console.ReadLine();

            double total = 0;

            switch (typeOfTerain)
            {
                case "trail":
                    total = (juniorsTrail * countJunior) + (seniorsTrail * countSeniors);
                    break;
                case "cross-country":
                    if ((countJunior + countSeniors) >= 50)
                    {
                        total = ((juniorsCrossCountry * countJunior) + (seniorsCrossCountry * countSeniors)) * 0.75;
                    }
                    else
                    {
                        total = (juniorsCrossCountry * countJunior) + (seniorsCrossCountry * countSeniors);
                    }
                    break;
                case "downhill":
                    total = (juniorsDownhill * countJunior) + (seniorsDownhill * countSeniors);
                    break;
                case "road":
                    total = (juniorsRoad * countJunior) + (seniorsRoad * countSeniors);
                    break;   
            }

            double priceAfterCost = total * 0.95;
            Console.WriteLine($"{priceAfterCost:f2}");
        }
    }
}
