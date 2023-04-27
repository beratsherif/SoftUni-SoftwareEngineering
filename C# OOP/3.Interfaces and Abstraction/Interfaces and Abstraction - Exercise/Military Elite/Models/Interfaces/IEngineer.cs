namespace Military_Elite.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
