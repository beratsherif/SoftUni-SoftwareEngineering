namespace _04._Wild_Farm.Models.Animals
{
    using Foods;
    using System.Collections.Generic;
    public class Hen : Bird
    {
        private const double HEN_MULTIP = 0.35;
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }

        protected override double WeightMultiplier => HEN_MULTIP;
        public override HashSet<string> PreferedFood => new HashSet<string>() {nameof(Vegetable),nameof(Fruit),nameof(Meat),nameof(Seeds) };
        public override string PoduceSound()
        {
            return "Cluck";
        }
    }
}
