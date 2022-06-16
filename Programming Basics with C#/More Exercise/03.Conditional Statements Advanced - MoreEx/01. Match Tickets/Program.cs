using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            const double VIP = 499.99;
            const double NORMAL = 249.99;

            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double priceForTransport = 0;

            if (people >= 1 && people <= 4)
            {
                priceForTransport = budget * 0.75;
            }
            else if (people > 4 && people <= 9)
            {
                priceForTransport = budget * 0.60;
            }
            else if (people > 9 && people <= 24)
            {
                priceForTransport = budget * 0.50;
            }
            else if (people > 24 && people <= 49)
            {
                priceForTransport = budget * 0.40;
            }
            else if (people > 49)
            {
                priceForTransport = budget * 0.25;
            }
            double moneyNeedForTheMach = 0;
            switch (type)
            {
                case"VIP":
                    moneyNeedForTheMach = people * VIP;
                    break;
                case"Normal":
                    moneyNeedForTheMach = people * NORMAL;
                    break;
            }
            double totalMoney = moneyNeedForTheMach + priceForTransport;
            double diference = Math.Abs(budget - totalMoney);
            if (budget >= totalMoney)
            {
                Console.WriteLine($"Yes! You have {diference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diference:f2} leva.");
            }
        }
    }
}
