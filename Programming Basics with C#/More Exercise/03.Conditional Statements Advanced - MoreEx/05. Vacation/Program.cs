using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string typePlace = "";
            string city = "";

            if (budget <= 1000)
            {
                typePlace = "Camp";
                switch (season)
                {
                    case"Summer":
                        price = budget * 0.65;
                        city = "Alaska";
                        break;
                    case"Winter":
                        price = budget * 0.45;
                        city = "Morocco";
                        break;

                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                typePlace = "Hut";
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.80;
                        city = "Alaska";
                        break;
                    case "Winter":
                        price = budget * 0.60;
                        city = "Morocco";
                        break;

                }
            }
            else
            {
                typePlace = "Hotel";
                price = budget * 0.90;
                switch (season)
                {
                    case "Summer":
                        city = "Alaska";
                        break;
                    case "Winter":
                        city = "Morocco";
                        break;

                }
            }
            Console.WriteLine($"{city} - {typePlace} - {price:f2}");
        }
    }
}
