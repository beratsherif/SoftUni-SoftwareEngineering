using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dogFoodPrice = 2.50;
            const double catFoodPrice = 4;

            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());

            double totalMoney = (dogFoodPrice * dogFood) + (catFoodPrice * catFood);

            Console.WriteLine($"{ totalMoney} lv.");


        }
    }
}
