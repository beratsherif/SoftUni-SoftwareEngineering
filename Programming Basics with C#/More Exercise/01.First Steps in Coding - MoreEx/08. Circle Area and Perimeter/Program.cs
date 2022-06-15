using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double calculatedArea = Math.PI * Math.Pow(r, 2);
            double parameter = 2 * Math.PI * r;

            Console.WriteLine($"{calculatedArea:f2}"); ;
            Console.WriteLine($"{parameter:f2}");
        }
    }
}
