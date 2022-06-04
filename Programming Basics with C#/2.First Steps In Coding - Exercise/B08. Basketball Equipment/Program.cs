using System;

namespace B08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerYear = double.Parse(Console.ReadLine());

            double basketballShoes = 0.6 * pricePerYear;
            double basketbalEquipment = 0.8 * basketballShoes;
            double basketbalBall = basketbalEquipment / 4;
            double basketballAccesories = basketbalBall / 5;

            double totalMoney = pricePerYear + basketballShoes + basketbalEquipment + basketbalBall + basketballAccesories;

            Console.WriteLine(totalMoney);
        }
    }
}
