using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string place = "";
            double spentMoney = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        spentMoney = budget * 0.3;
                        place = "Camp";
                        break;
                    case "winter":
                        spentMoney = budget * 0.7;
                        place = "Hotel";
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        spentMoney = budget * 0.4;
                        place = "Camp";
                        break;
                    case "winter":
                        spentMoney = budget * 0.8;
                        place = "Hotel";
                        break;
                }
            }
            else
            {
                destination = "Europe";
                spentMoney = budget * 0.9;
                place = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {spentMoney:f2}");

        }
    }
}
