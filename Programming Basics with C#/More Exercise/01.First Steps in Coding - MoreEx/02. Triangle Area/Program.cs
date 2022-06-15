using System;

namespace _02._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            double result = (a * ha) / 2;
            Console.WriteLine($"{result:f2}");
        }
    }
}
