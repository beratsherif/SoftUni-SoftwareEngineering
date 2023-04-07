using System;
using System.Collections.Generic;
using System.Text;

namespace Cars2
{
    public abstract class BaseElectricCar : BaseCar

    {
        protected BaseElectricCar(string model, string color,int battery) : base(model, color)
        {
            this.Battery = battery;
        }

        public int Battery { get; set; }
    }
}
