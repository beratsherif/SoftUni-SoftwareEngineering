namespace _04._Wild_Farm.Models.Animals
{
    using System.Collections.Generic;
    using Foods;
    public class Cat : Feline
    {
        private const double CAT_MULTIP = 0.3;
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {

        }

        protected override double WeightMultiplier => CAT_MULTIP;
        public override HashSet<string> PreferedFood => new HashSet<string>() {nameof(Vegetable), nameof(Meat) };
        public override string PoduceSound()
        {
            return "Meow";
        }
    }
}
