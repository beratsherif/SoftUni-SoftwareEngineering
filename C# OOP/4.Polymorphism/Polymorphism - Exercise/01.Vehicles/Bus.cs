using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double bussAirConditionerIncrease = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double fuelTank) : base(fuelQuantity, fuelConsumption, fuelTank, bussAirConditionerIncrease)
        {

        }

        public void TurnOn()
        {
            this.AirConditioningIncreace = bussAirConditionerIncrease;
        }

        public void TurnOff()
        {
            this.AirConditioningIncreace = 0;
        }
    }
}
