namespace _04._Wild_Farm.Models.Animals
{
    using System.Collections.Generic;
    using Foods;
    public class Dog : Mammal
    {
        private const double DOG_MULTIP = 0.4;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }

        protected override double WeightMultiplier => DOG_MULTIP;
        public override HashSet<string> PreferedFood => new HashSet<string>() {nameof(Meat) };
        public override string PoduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
