using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Topping
    {
        private const int minVal = 1;
        private const int maxVal = 50;

        private int weight;
        private string topping;

        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            {"meat",1.2},
            {"veggies",0.8},
            {"cheese",1.1},
            {"sauce",0.9}
        };

        public Topping(string topping, int weight)
        {
            Toping = topping;
            Weight = weight;
        }
        public string Toping
        {
            get
            {
                return topping;
            }
            private set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                topping = value;
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Toping} weight should be in the range [{minVal}..{maxVal}].");
                }

                weight = value;
            }
        }

        public double Calories
            => 2
               * Weight
               * modifiers[Toping.ToLower()];
    }
}
