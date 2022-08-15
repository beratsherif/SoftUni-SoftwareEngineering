using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int consumedByWorkers = 26;
            const int minimumSpicesneeded = 100;
            const int dailyDecreesOfMine = 10;

            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCounter = 0;

            while (countOfSpices >= minimumSpicesneeded)
            {
                totalConsumed += countOfSpices - consumedByWorkers;
                countOfSpices -= dailyDecreesOfMine;
                daysCounter++;
                if (countOfSpices < minimumSpicesneeded)
                {
                    totalConsumed -= consumedByWorkers;
                }
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalConsumed);
        }
    }
}
