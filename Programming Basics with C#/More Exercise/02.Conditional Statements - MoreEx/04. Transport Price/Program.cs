using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            const double taxiStartingPrice = 0.70;
            const double taxiPricePerKmAtDay = 0.79;
            const double taxiPricePerKmAtNight = 0.90;
            const double busPrice = 0.09;
            const double trainPrice = 0.06;

            int km = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            double price = 0;

            if (km >= 100)
            {
                price = km * trainPrice;
            }
            else if (km >= 20 && km < 100)
            {
                price = km * busPrice;
            }
            else
            {
                switch (timeOfTheDay)
                {
                    case "day":
                        price = (km * taxiPricePerKmAtDay) + taxiStartingPrice;
                        break;
                    case "night":
                        price = (km * taxiPricePerKmAtNight) + taxiStartingPrice;
                        break;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
