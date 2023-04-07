using System;
using System.Collections.Generic;
using System.Text;

namespace Cars2
{
    public abstract class BaseCar
    {
        public BaseCar(string model,string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Model { get; set; }
        public string  Color { get; set; }  

    }
}
