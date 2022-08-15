using System;

namespace _02.Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dolars = pounds * 1.31;
            Console.WriteLine($"{dolars:f3}");
        }
    }
}
