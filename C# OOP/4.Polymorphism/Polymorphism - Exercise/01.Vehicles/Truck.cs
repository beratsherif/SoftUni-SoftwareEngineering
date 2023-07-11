using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double fuelTank) : base(fuelQuantity, fuelConsumption, fuelTank, 1.6)
        {

        }

        public override void Refueling(double quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (quantity + FuelQuantity > FuelTank)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }

            FuelQuantity += quantity * 0.95;
        }
    }
}
