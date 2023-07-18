namespace _04._Wild_Farm.Models.Animals
{
    using System.Collections.Generic;
    using Foods;
    public class Tiger : Feline
    {
        private const double TIGER_MULTIP = 1;
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {

        }

        protected override double WeightMultiplier => TIGER_MULTIP;
        public override HashSet<string> PreferedFood => new HashSet<string>() {nameof(Meat) };
        public override string PoduceSound()
        {
            return "ROAR!!!";
        }
    }
}
