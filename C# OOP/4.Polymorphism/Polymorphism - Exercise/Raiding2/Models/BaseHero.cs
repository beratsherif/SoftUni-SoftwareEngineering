using Raiding2.Models.Interfaces;

namespace Raiding2.Models
{
    public abstract class BaseHero : IBaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
        public virtual int Power { get; private set; }
        public abstract string CastAbility();
    }
}
