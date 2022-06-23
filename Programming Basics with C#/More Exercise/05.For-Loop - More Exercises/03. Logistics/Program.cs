using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            int minibus = 0;
            int truck = 0;
            int train = 0;

            for (int i = 0; i < cargoCount; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                if (tons <= 3)
                {
                    minibus += tons;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    truck += tons;
                }
                else
                {
                    train += tons;
                }
            }
            int total = minibus + truck + train;
            double averagePrice = (minibus * 200 + truck * 175 + train * 120) / (double)total;
            double percentMinibus = (double)minibus / total * 100.00;
            double percentTruck = (double)truck / total * 100.00;
            double percentTrain = (double)train / total * 100.00;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentMinibus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}
