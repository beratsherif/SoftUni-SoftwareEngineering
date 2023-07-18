namespace _04._Wild_Farm.Models.Animals
{
    using System.Collections.Generic;
    using Foods;
    public class Owl : Bird
    {
        private const double OWL_MULTIP = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }

        protected override double WeightMultiplier => OWL_MULTIP;
        public override HashSet<string> PreferedFood => new HashSet<string>() {nameof(Meat) };
        public override string PoduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
