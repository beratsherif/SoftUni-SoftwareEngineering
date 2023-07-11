using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = ConsoleFiller(carInfo);
            Vehicle truck = ConsoleFiller(truckInfo);
            Vehicle bus = ConsoleFiller(busInfo);

            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                string[] lineArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = lineArgs[0];
                string type = lineArgs[1];
                double value = double.Parse(lineArgs[2]);

                if (command == "DriveEmpty")
                {
                    try
                    {
                        ((Bus)bus).TurnOff();
                        bus.Drive(value);
                        Console.WriteLine($"{type} travelled {value} km");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (command == "Drive")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Drive(value);
                        }
                        else if (type == nameof(Truck))
                        {
                            truck.Drive(value);
                        }
                        else if (type == nameof(Bus))
                        {
                            ((Bus)bus).TurnOn();
                            bus.Drive(value);
                        }

                        Console.WriteLine($"{type} travelled {value} km");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (command == "Refuel")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Refueling(value);
                        }
                        else if (type == nameof(Truck))
                        {
                            truck.Refueling(value);
                        }
                        else if (type == nameof(Bus))
                        {
                            bus.Refueling(value);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }

        private static Vehicle ConsoleFiller(string[] args)
        {
            Vehicle vehicle = null;

            string type = args[0];
            double fuelQuantity = double.Parse(args[1]);
            double fuelConsumption = double.Parse(args[2]);
            double fuelTank = double.Parse(args[3]);

            if (type == nameof(Car))
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, fuelTank);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, fuelTank);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, fuelTank);
            }

            return vehicle;
        }
    }
}
