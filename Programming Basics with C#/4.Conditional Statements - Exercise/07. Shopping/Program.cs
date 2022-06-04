using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            const double videoCardPrice = 250;

            double budgetPeter = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());

            double totalVideoCardPrice = videoCard * videoCardPrice;
            double totalProcesorsPrice = (totalVideoCardPrice * 0.35) * procesors;
            double totalRamMemoryPrice = (totalVideoCardPrice * 0.1) * ramMemory;

            double totalCost = totalVideoCardPrice + totalProcesorsPrice + totalRamMemoryPrice;

            if (videoCard > procesors)
            {
                totalCost *= 0.85;
            }
            double difference = Math.Abs(totalCost - budgetPeter);
            if (totalCost <= budgetPeter)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
            }
        }
    }
}
