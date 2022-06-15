using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodSheLeft = int.Parse(Console.ReadLine());

            double foodForDogPerDay = double.Parse(Console.ReadLine());
            double foodForCatPerDay = double.Parse(Console.ReadLine());
            double foodForTurtlePerDay = double.Parse(Console.ReadLine()) / 1000;

            double totalKgFoodTheyNeed = (foodForDogPerDay + foodForCatPerDay + foodForTurtlePerDay) * days;

            double diff = Math.Abs(foodSheLeft - totalKgFoodTheyNeed);

            if (totalKgFoodTheyNeed <= foodSheLeft)
            {
                Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(diff)} more kilos of food are needed.");
            }
        }
    }
}
