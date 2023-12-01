namespace Raiding2.Factories.Interfaces
{
    using Raiding2.Models.Interfaces;
    public interface IBaseHeroFactory
    {
        IBaseHero CreateHero(string name);
    }
}
