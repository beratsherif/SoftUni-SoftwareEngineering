using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double magnolias = 3.25;
            const double hyacinth = 4;
            const double rose = 3.50;
            const double cactus = 8;

            int magnoliasNum = int.Parse(Console.ReadLine());
            int hyacinthNum = int.Parse(Console.ReadLine());
            int roseNum = int.Parse(Console.ReadLine());
            int cactusNum = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double totalFlowersSum = (magnolias * magnoliasNum) + (hyacinth * hyacinthNum) + (rose * roseNum) + (cactus * cactusNum);

            double finalFlowerSum = totalFlowersSum * 0.95;
            double difference = Math.Abs(presentPrice - finalFlowerSum);

            if (finalFlowerSum >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
            }
        }
    }
}
