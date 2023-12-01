namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int WARRIOR_POWER = 100;
        public Warrior(string name) : base(name)
        {
            
        }

        public override int Power => WARRIOR_POWER;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
