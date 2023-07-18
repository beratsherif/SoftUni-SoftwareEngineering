namespace _04._Wild_Farm.Models.Animals
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    public abstract class Animal : IAnimal
    {
        public Animal()
        {
            this.FoodEaten = 0;
        }

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

        protected abstract double WeightMultiplier { get; }// important
        public abstract HashSet<string> PreferedFood { get; }// important

        public abstract string PoduceSound();

        public void Eat(IFood food)
        {
            if (!PreferedFood.Contains(food.GetType().Name))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.FoodEaten += food.Quantity;
            this.Weight += WeightMultiplier * food.Quantity;
        }

        public override string ToString() // important
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
