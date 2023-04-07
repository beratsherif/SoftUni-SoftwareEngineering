using System;

namespace Cars2
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BaseCar seat = new Seat("Leon", "Black");
            BaseElectricCar tesla = new Tesla("Model S ", "Grey",1);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
