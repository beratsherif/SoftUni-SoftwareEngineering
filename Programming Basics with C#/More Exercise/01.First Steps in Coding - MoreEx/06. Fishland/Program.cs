using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            const double musslesPrice = 7.50;

            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());

            double palamudPrice = (0.6 * skumriqPrice) + skumriqPrice;
            double safridPrice = (0.8 * cacaPrice) + cacaPrice;

            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMussles = int.Parse(Console.ReadLine());

            double totalPrice = (kgPalamud * palamudPrice) + (kgSafrid * safridPrice) + (kgMussles * musslesPrice);

            Console.WriteLine($"{totalPrice:f2}") ;
        }
    }
}
