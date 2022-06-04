using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double metersHeNeedToSwim = double.Parse(Console.ReadLine());
            double secondsForMeter = double.Parse(Console.ReadLine());

            double timeForMeters = secondsForMeter * metersHeNeedToSwim;
            double slowdown = (Math.Floor(metersHeNeedToSwim / 15)) * 12.5;
            double totalTime = timeForMeters + slowdown;

            if (totalTime < recordSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordSeconds:f2} seconds slower.");
            }
        }
    }
}
