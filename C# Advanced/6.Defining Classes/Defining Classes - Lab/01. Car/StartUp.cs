using System;

namespace _01._Car
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Mercedes-Benz";
            car1.Model = "c220 CDI";
            car1.Year = 2007;

            Console.WriteLine($"Make:{car1.Make} Model:{car1.Model} Year:{car1.Year}");
        }
    }
}
