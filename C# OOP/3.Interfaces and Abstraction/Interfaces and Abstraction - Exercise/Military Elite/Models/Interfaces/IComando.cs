using System.Collections.Generic;

namespace Military_Elite.Models.Interfaces
{
    interface IComando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
    }
}
