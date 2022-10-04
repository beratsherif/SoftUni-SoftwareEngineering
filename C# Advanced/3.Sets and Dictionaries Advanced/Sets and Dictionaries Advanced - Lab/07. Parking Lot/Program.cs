using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carsInParking = new HashSet<string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(", ");
                if (command[0] == "END")
                {
                    break;
                }

                string direction = command[0];
                string carNumber = command[1];

                switch (direction)
                {
                    case "IN":
                        carsInParking.Add(carNumber);
                        break;
                    case "OUT":
                        carsInParking.Remove(carNumber);
                        break;
                }
            }

            if (carsInParking.Count > 0)
            {
                foreach (var car in carsInParking)
                {
                    Console.WriteLine(car);
                }
            }
            else
                Console.WriteLine("Parking Lot is Empty");
        }
    }
}
