namespace RobotService.Repositories
{
    using Repositories.Contracts;
    using Models.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class SupplementRepository : IRepository<ISupplement>
    {
        private List<ISupplement> supplements;
        public SupplementRepository()
        {
            supplements = new List<ISupplement>();
        }
        public void AddNew(ISupplement model)
        {
            this.supplements.Add(model);
        }

        public ISupplement FindByStandard(int interfaceStandard)
        {
            ISupplement currSupp = supplements.FirstOrDefault(s => s.InterfaceStandard == interfaceStandard);
            if (currSupp == null)
            {
                return null;
            }
            return currSupp;
        }

        public IReadOnlyCollection<ISupplement> Models()
        {
            return this.supplements.AsReadOnly();
        }

        public bool RemoveByName(string typeName)
        {
            ISupplement currSupp = supplements.FirstOrDefault(s => s.GetType().Name == typeName);
            if (currSupp == null)
            {
                return false;
            }
            supplements.Remove(currSupp);
            return true;
        }
    }
}
