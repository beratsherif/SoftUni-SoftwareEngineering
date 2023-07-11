using System;
using System.Threading.Channels;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double fuelTank, double airConditioningIncreace)
        {
            this.FuelTank = fuelTank;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.AirConditioningIncreace = airConditioningIncreace;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set
            {
                if (value > this.FuelTank)
                {
                    this.FuelTank = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; private set; }
        public double FuelTank { get; private set; }
        protected double AirConditioningIncreace { get; set; } // protected

        public void Drive(double distance)
        {
            double neededFuel = distance * (FuelConsumption + AirConditioningIncreace);

            if (neededFuel > FuelQuantity)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            FuelQuantity -= neededFuel;
        }

        public virtual void Refueling(double quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (quantity + FuelQuantity > FuelTank)
            {
                throw new ArgumentException($"Cannot fit {quantity} fuel in the tank");
            }

            this.FuelQuantity += quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
