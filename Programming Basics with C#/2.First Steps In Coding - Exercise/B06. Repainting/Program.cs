using System;

namespace B06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            const double naylonPrice = 1.50;
            const double paintPrice = 14.50;
            const double thinnerPrice = 5.00;
            const double bagPrice = 0.40;

            int neededNylon = int.Parse(Console.ReadLine());
            int neededPaint = int.Parse(Console.ReadLine());
            int neededThinner = int.Parse(Console.ReadLine());
            int neededHoursForWorkers = int.Parse(Console.ReadLine());

            double nylonSum = (neededNylon + 2) * naylonPrice;
            double paintSum = (neededPaint + (neededPaint * 0.1)) * paintPrice;
            double thinnerSum = neededThinner * thinnerPrice;

            double totalSum = nylonSum + paintSum + thinnerSum + bagPrice;
            double neededMoneyForWorkers = (totalSum * 0.3) * neededHoursForWorkers;
            double FinalSum = totalSum + neededMoneyForWorkers;

            Console.WriteLine($"{FinalSum}");

        }
    }
}
