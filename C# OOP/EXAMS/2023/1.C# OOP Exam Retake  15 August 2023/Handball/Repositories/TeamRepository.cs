namespace Handball.Repositories
{
    using Handball.Models.Contracts;
    using Handball.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamRepository : IRepository<ITeam>
    {
        private List<ITeam> models;
        public TeamRepository()
        {
            this.models = new List<ITeam>();
        }
        public IReadOnlyCollection<ITeam> Models => this.models.AsReadOnly();

        public void AddModel(ITeam model)
        {
            models.Add(model);
        }

        public bool RemoveModel(string name)
        {
            ITeam team = models.FirstOrDefault(t => t.Name == name);
            if (team != null)
            {
                models.Remove(team);
                return true;
            }
            return false;
        }
        public bool ExistsModel(string name)
        {
            ITeam team = models.FirstOrDefault(t => t.Name == name);
            if (team != null)
            {
                return true;
            }
            return false;
        }

        public ITeam GetModel(string name)
        {
            ITeam team = models.FirstOrDefault(t => t.Name == name);
            if (team != null)
            {
                return team;
            }
            return null;
        }

      
    }
}
