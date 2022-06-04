using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double total = 0;

            switch (flowerType)
            {
                case "Roses":
                    total = 5.00 * flowerCount;
                    if (flowerCount > 80)
                    {
                        total *= 0.90;
                    }
                    break;
                case "Dahlias":
                    total = 3.80 * flowerCount;
                    if (flowerCount > 90)
                    {
                        total *= 0.85;
                    }
                    break;
                case "Tulips":
                    total = 2.80 * flowerCount;
                    if (flowerCount > 80)
                    {
                        total *= 0.85;
                    }
                    break;
                case "Narcissus":
                    total = 3.00 * flowerCount;
                    if (flowerCount < 120)
                    {
                        total *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    total = 2.50 * flowerCount;
                    if (flowerCount < 80)
                    {
                        total *= 1.20;
                    }
                    break;
            }

            double difference = Math.Abs(budget - total);

            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }

        }
    }
}
