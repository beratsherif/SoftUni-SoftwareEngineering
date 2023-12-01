namespace RobotService.Repositories
{
    using Models.Contracts;
    using Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class RobotRepository : IRepository<IRobot>
    {
        private List<IRobot> robots;
        public RobotRepository()
        {
            robots = new List<IRobot>();
        }
        public IReadOnlyCollection<IRobot> Models()
        {
            return robots.AsReadOnly();
        }
        public void AddNew(IRobot model)
        {
            robots.Add(model);
        }
        public bool RemoveByName(string typeName)
        {
            IRobot currRobot = robots.FirstOrDefault(r => r.GetType().Name == typeName);
            if (currRobot == null)
            {
                return false;
            }
            robots.Remove(currRobot);
            return true;
        }
        public IRobot FindByStandard(int interfaceStandard)
        {
            IRobot currRobot = robots.FirstOrDefault(r => r.InterfaceStandards.Contains(interfaceStandard));
            if (currRobot == null)
            {
                return null;
            }
            return currRobot;
        }
    }
}
