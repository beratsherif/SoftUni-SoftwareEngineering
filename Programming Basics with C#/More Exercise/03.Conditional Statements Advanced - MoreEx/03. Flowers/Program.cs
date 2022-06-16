using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            double chrysanthemum = 0;
            double rose = 0;
            double tulip = 0;

            int counOfChrysanthemum = int.Parse(Console.ReadLine());
            int countOfRose = int.Parse(Console.ReadLine());
            int countOfTulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string day = Console.ReadLine();

            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrysanthemum = 2;
                    rose = 4.10;
                    tulip = 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    chrysanthemum = 3.75;
                    rose = 4.50;
                    tulip = 4.15;
                    break;
            }

            double totalMoneyForFlowers = (chrysanthemum * counOfChrysanthemum) + (rose * countOfRose) + (tulip * countOfTulip);

            if (day == "Y")
            {
                totalMoneyForFlowers *= 1.15;
            }
            if (countOfTulip > 7 && season == "Spring")
            {
                totalMoneyForFlowers *= 0.95;
            }
            if (countOfRose >= 10 && season == "Winter")
            {
                totalMoneyForFlowers *= 0.9;
            }
            if ((counOfChrysanthemum + countOfRose + countOfTulip) > 20)
            {
                totalMoneyForFlowers *= 0.8;
            }

            double finalPrice = totalMoneyForFlowers + 2;

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
