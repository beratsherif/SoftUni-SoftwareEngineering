using System;

namespace _10._Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());

            if (C <= 35 && C >= 26)
            {
                Console.WriteLine("Hot");
            }
            else if (C <= 25.9 && C >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (C <= 20 && C >= 15)
            {
                Console.WriteLine("Mild");
            }
            else if (C <= 14.9 && C >= 12)
            {
                Console.WriteLine("Cool");
            }
            else if (C <= 11.9 && C >= 5)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
