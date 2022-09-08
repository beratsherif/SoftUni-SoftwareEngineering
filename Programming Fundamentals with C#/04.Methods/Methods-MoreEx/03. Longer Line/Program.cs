using System;
using System.ComponentModel.Design;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            PrintTheResult(x1, y1, x2, y2, X1, Y1, X2, Y2);
        }

        private static void PrintTheResult(double x1, double y1, double x2, double y2, double secondX1, double secondY1, double secondX2, double secondY2)
        {
            double firstCombination = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            double secondCombination = Math.Abs(secondX1) + Math.Abs(secondY1) + Math.Abs(secondX2) + Math.Abs(secondY2);

            if (firstCombination >= secondCombination)
            {
                double first = Math.Abs(x1) + Math.Abs(y1);
                double second = Math.Abs(x2) + Math.Abs(y2);

                if (first > second)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
            }
            else
            {
                double firstElse = Math.Abs(secondX1) + Math.Abs(secondY1);
                double secondElse = Math.Abs(secondX2) + Math.Abs(secondY2);

                if (firstElse > secondElse)
                {
                    Console.WriteLine($"({secondX2}, {secondY2})({secondX1}, {secondY1})");
                }
                else
                {
                    Console.WriteLine($"({secondX1}, {secondY1})({secondX2}, {secondY2})");
                }
            }
        }
    }
}
