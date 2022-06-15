using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            const double windows = (1.5 * 1.5) * 2;
            const double door = 1.2 * 2;

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontAndBackWall = (x * x) * 2;
            double leftAndRightWall = (x * y) * 2;

            double frontAndBAckWAllOfTheTop = x * h;
            double leftAndRightWallOfTheTop = (x * y) * 2;

            double neededGreenPaint = ((frontAndBackWall - door) + (leftAndRightWall - windows)) / 3.4;
            double neededRedPaint = (frontAndBAckWAllOfTheTop + leftAndRightWallOfTheTop) / 4.3;

            Console.WriteLine($"{neededGreenPaint:f2}");
            Console.WriteLine($"{neededRedPaint:f2}");

        }
    }
}
