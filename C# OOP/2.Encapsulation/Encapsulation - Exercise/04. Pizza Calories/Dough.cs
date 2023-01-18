﻿using System;
using System.Collections.Generic;

namespace _04._Pizza_Calories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weigh;

        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            {"white",1.5},
            {"wholegrain",1.0},
            {"crispy",0.9},
            {"chewy",1.1},
            {"homemade",1.0},
        };

        public Dough(string flourType,string bakingTechnique,int weigh)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weigh = weigh;
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            private set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }

        public int Weigh
        {
            get
            {
                return weigh;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                weigh = value;
            }
        }

        public double Calories()
        {
            double calories = 2 * Weigh * modifiers[FlourType.ToLower()] * modifiers[bakingTechnique.ToLower()];
            return calories;
        }
    }
}
