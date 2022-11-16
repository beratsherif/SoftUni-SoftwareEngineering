using System;
using System.Runtime.ConstrainedExecution;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int horsePower = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());

            Vehicle vehicle = new Vehicle(horsePower, fuel);
            vehicle.Drive(10);
            Console.WriteLine(vehicle.Fuel);
        }
    }
}
