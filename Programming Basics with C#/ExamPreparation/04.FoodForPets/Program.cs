using System;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double totalEatenFood = 0;
            double totalDogEaten = 0;
            double totalCatEaten = 0;
            double biscuits = 0;

            for (int i = 1; i <= days; i++)
            {
                double foodForTheDay = 0;
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());
                totalDogEaten += dogFood;
                totalCatEaten += catFood;
                foodForTheDay = dogFood + catFood;
                if (i % 3 == 0)
                {
                    double eatenBiscuits = foodForTheDay * 0.10;
                    biscuits += eatenBiscuits;
                }
                totalEatenFood += foodForTheDay;

            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{totalEatenFood / food * 100.00:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalDogEaten / totalEatenFood * 100.00:f2}% eaten from the dog.");
            Console.WriteLine($"{totalCatEaten / totalEatenFood * 100.00:f2}% eaten from the cat.");
        }
    }
}
