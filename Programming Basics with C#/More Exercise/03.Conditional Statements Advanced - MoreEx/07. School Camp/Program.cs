using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string goupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = "";
            double priceForOneNight = 0;

            switch (season)
            {
                case "Winter":
                    switch (goupType)
                    {
                        case "boys":
                            priceForOneNight = 9.60;
                            sport = "Judo";
                            break;
                        case "girls":
                            priceForOneNight = 9.60;
                            sport = "Gymnastics";
                            break;
                        case "mixed":
                            priceForOneNight = 10;
                            sport = "Ski";
                            break;
                    }
                    break;
                case "Spring":
                    switch (goupType)
                    {
                        case "boys":
                            priceForOneNight = 7.20;
                            sport = "Tennis";
                            break;
                        case "girls":
                            priceForOneNight = 7.20;
                            sport = "Athletics";
                            break;
                        case "mixed":
                            priceForOneNight = 9.50;
                            sport = "Cycling";
                            break;
                    }
                    break;
                case "Summer":
                    switch (goupType)
                    {
                        case "boys":
                            priceForOneNight = 15;
                            sport = "Football";
                            break;
                        case "girls":
                            priceForOneNight = 15;
                            sport = "Volleyball";
                            break;
                        case "mixed":
                            priceForOneNight = 20;
                            sport = "Swimming";
                            break;
                    }
                    break;
            }

            double price = studentsCount * priceForOneNight * nights;

            if (studentsCount >= 50 )
            {
                price *= 0.5;
            }
            else if (studentsCount >= 20 && studentsCount < 50)
            {
                price *= 0.85;
            }
            else if (studentsCount >= 10 && studentsCount < 20)
            {
                price *= 0.95;
            }

            Console.WriteLine($"{sport} {price:F2} lv.");
        }
    }
}
