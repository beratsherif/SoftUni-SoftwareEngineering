using System;

namespace B01._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            const double fixedValue = 1.79549;
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(fixedValue * n);
        }
    }
}
