using System;

namespace B07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            const double chichkenMenu = 10.35;
            const double fishMenu = 12.40;
            const double vegetarianMenu = 8.15;
            const double deliveryPrice = 2.50;

            int chichkenMenuNum = int.Parse(Console.ReadLine());
            int fishMenuNum = int.Parse(Console.ReadLine());
            int vegetarianMenuNum = int.Parse(Console.ReadLine());

            double totalMoney = (chichkenMenu * chichkenMenuNum) + (fishMenu * fishMenuNum) + (vegetarianMenu * vegetarianMenuNum);

            double desertPrice = totalMoney * 0.2;

            double finalMoney = totalMoney + desertPrice + deliveryPrice;

            Console.WriteLine(finalMoney);


        }
    }
}
