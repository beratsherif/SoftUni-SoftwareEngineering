using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            const double neededKgFor1Littre = 2.5;

            int xArea = int.Parse(Console.ReadLine());
            double kgGreapes = double.Parse(Console.ReadLine());
            int neededLittresWine = int.Parse(Console.ReadLine());
            int coutWorkers = int.Parse(Console.ReadLine());

            double totalKG = xArea * kgGreapes * 0.4;
            double finalWineLittre = totalKG / 2.5;

            double diff = Math.Abs(finalWineLittre - neededLittresWine);

            if (finalWineLittre >= neededLittresWine)
            {
                double wineForWorkers = diff / coutWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(finalWineLittre)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(wineForWorkers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }



        }
    }
}
