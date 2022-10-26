using System;

namespace _02._Car_Extension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Mercedes-Benz";
            car.Model = "c220 CDI";
            car.Year = 2007;
            car.FuelQuantity = 66;
            car.FuelConsumption = 2;
            car.Drive(30);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
