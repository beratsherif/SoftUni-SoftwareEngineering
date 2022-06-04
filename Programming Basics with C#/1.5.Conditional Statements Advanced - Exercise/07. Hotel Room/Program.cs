using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    apartmentPrice = 65 * nights;
                    if (nights > 7 && nights <= 14)
                    {
                        studioPrice = 50 * nights * 0.95;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = 50 * nights * 0.70;
                    }
                    else
                    {
                        studioPrice = 50 * nights;
                    }
                    break;
                case "June":
                case "September":
                    apartmentPrice = 68.70 * nights;
                    if (nights > 14)
                    {
                        studioPrice = 75.20 * nights * 0.80;
                    }
                    else
                    {
                        studioPrice = 75.20 * nights;
                    }
                    break;
                case "July":
                case "August":
                    apartmentPrice = 77 * nights;
                    studioPrice = 76 * nights;
                    break;
            }
            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
