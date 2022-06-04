using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            const double roomFor1Person = 18.00;
            const double apartmentPrice = 25.00;
            const double presidentApartmentPrice = 35.00;

            int days = int.Parse(Console.ReadLine()) - 1;
            string typePlace = Console.ReadLine();
            string review = Console.ReadLine();

            double total = 0;

            switch (typePlace)
            {
                case "room for one person":
                    total = roomFor1Person * days;
                    break;
                case "apartment":
                    if (days < 10)
                    {
                        total = apartmentPrice * days * 0.70;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        total = apartmentPrice * days * 0.65;
                    }
                    else
                    {
                        total = apartmentPrice * days * 0.50;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        total = presidentApartmentPrice * days * 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        total = presidentApartmentPrice * days * 0.85;
                    }
                    else
                    {
                        total = presidentApartmentPrice * days * 0.80;
                    }
                    break;
            }
            switch (review)
            {
                case "positive":
                    total *= 1.25;
                    break;
                case "negative":
                    total *= 0.90;
                    break;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
