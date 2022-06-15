using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()) * 100;
            double h = double.Parse(Console.ReadLine()) * 100;

            

            double rows = Math.Floor(w / 120);
            double colons = Math.Floor((h - 100) / 70);

            double finalResult = (rows * colons) - 3;

            Console.WriteLine(finalResult);
        }
    }
}
