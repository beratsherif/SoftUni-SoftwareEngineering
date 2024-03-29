﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_FUEL_CONSMP = 1.25;

        public Vehicle(int horsePower,double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public virtual double FuelConsumption => DEFAULT_FUEL_CONSMP;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            if (this.Fuel - (kilometers * this.FuelConsumption) >= 0 )
            {
                this.Fuel -= kilometers * this.FuelConsumption;
            }
        }
    }
}
