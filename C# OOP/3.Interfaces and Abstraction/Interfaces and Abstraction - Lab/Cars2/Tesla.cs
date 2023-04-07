using System;
using System.Collections.Generic;
using System.Text;

namespace Cars2
{
    public class Tesla : BaseElectricCar
    {
        public Tesla(string model, string color, int battery) : base(model, color, battery){ }

        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} Batteries";
        }
    }
}
