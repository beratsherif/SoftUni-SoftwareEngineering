using System;

namespace _09._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();

            switch (weather)
            {
                case "sunny":
                    Console.WriteLine("It's warm outside!");
                    break;
                case "cloudy":
                    Console.WriteLine("It's cold outside!");
                    break;
                default:
                    Console.WriteLine("It's cold outside!");
                    break;

            }
        }
    }
}
