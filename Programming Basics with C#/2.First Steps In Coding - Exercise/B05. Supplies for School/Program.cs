using System;

namespace B05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pens = 5.80;
            const double markers = 7.20;
            const double preparation = 1.20;

            int pensNum = int.Parse(Console.ReadLine());
            int markersNum = int.Parse(Console.ReadLine());
            int preparationNum = int.Parse(Console.ReadLine());
            double percentSale = double.Parse(Console.ReadLine()) / 100;

            
            double totalPrice = (pens * pensNum) + (markers * markersNum) + (preparation * preparationNum);

            double finalPrice = totalPrice - (totalPrice * percentSale);
            
            Console.WriteLine(finalPrice);
        }
    }
}
