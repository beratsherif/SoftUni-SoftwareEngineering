using System;

namespace _01.Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPirce = double.Parse(Console.ReadLine());
            double babanaCout = double.Parse(Console.ReadLine());
            double orangeCout = double.Parse(Console.ReadLine());
            double berryCout = double.Parse(Console.ReadLine());
            double strawberryCout = double.Parse(Console.ReadLine());

            double berryPrice = strawberryPirce * 0.5;
            double orangePrice = berryPrice * 0.6;
            double bananaPrice = berryPrice * 0.2;

            double total = (strawberryPirce * strawberryCout) + (bananaPrice * babanaCout) + (orangePrice * orangeCout) + (berryPrice * berryCout);

            Console.WriteLine($"{total:f2}");
        }
    }
}
