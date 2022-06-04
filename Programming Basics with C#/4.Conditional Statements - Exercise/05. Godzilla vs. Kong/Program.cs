using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            double statists = double.Parse(Console.ReadLine());
            double clothPrice = double.Parse(Console.ReadLine());

            double decorPrice = filmBudget * 0.1;

            if (statists > 150)
            {
                clothPrice *= 0.90;
            }

            double totalPriceForClothes = clothPrice * statists;
            double totalMoneyNeed = totalPriceForClothes + decorPrice;
            double difference = Math.Abs(filmBudget - totalMoneyNeed);
            if (totalMoneyNeed <= filmBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:f2} leva more.");
            }
        }
    }
}
