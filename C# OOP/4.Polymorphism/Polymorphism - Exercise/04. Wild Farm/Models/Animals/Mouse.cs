namespace _04._Wild_Farm.Models.Animals
{
    using System.Collections.Generic;
    using Foods;
    public class Mouse : Mammal
    {
        private const double MOUSE_MULTIP = 0.1;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }

        protected override double WeightMultiplier => MOUSE_MULTIP;
        public override HashSet<string> PreferedFood => new HashSet<string>() {nameof(Vegetable),nameof(Fruit) };
        public override string PoduceSound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
