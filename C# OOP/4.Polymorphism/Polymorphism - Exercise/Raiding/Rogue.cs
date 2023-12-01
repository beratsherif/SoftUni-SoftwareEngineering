namespace Raiding
{
    public class Rogue : BaseHero
    {
        private const int ROGUE_POWER = 80;
        public Rogue(string name) : base(name)
        {

        }

        public override int Power => ROGUE_POWER;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
