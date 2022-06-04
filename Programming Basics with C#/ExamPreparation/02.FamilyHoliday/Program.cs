using System;

namespace _02.FamilyHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                priceForNight *= 0.95;
            }

            double total = nights * priceForNight;
            double other = ((double)percent / 100) * budget;
            double finalPrice = total + other;

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - finalPrice:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{finalPrice - budget:f2} leva needed.");
            }
        }
    }
}
