using System;
using System.Collections.Generic;
using System.Text;

namespace Cars2
{
    public class Seat : BaseCar
    {
        public Seat(string model, string color) : base(model, color){ }

        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}
