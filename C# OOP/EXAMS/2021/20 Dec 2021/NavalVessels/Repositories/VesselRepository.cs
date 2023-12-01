namespace NavalVessels.Repositories
{
    using Contracts;
    using NavalVessels.Models.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class VesselRepository : IRepository<IVessel>
    {
        private readonly ICollection<IVessel> vessels;
        public VesselRepository()
        {
            this.vessels = new HashSet<IVessel>();
        }
        public IReadOnlyCollection<IVessel> Models => (IReadOnlyCollection<IVessel>)this.vessels;

        public void Add(IVessel model)
        {
            vessels.Add(model);
        }

        public IVessel FindByName(string name)
        {
            return this.vessels.FirstOrDefault(v => v.Name == name);
        }

        public bool Remove(IVessel model)
        {
            return this.vessels.Remove(model);
        }
    }
}
