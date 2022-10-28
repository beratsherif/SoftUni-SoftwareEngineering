using System;

namespace _04._Car_Engine_And_Tires
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3)
            };

            Engine engine = new Engine(560, 6300);

            Car car = new Car("Mercedes-Benz", "C63", 2007, 66, 3, engine, tires);
        }
    }
}
