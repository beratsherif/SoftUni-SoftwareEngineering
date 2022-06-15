using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            const double evro = 1.94;

            double fruitPrice = double.Parse(Console.ReadLine());
            double vegePrice = double.Parse(Console.ReadLine());
            double fruitQuantity = double.Parse(Console.ReadLine());
            double vegeQuantity = double.Parse(Console.ReadLine());

            double totalSum = (fruitPrice * fruitQuantity) + (vegePrice * vegeQuantity);
            double totalSumEvro = totalSum / evro;

            Console.WriteLine($"{totalSumEvro:f2}");


        }
    }
}
