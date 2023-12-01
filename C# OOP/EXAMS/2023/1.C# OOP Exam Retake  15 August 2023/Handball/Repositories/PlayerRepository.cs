namespace Handball.Repositories
{
    using Handball.Models.Contracts;
    using Handball.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class PlayerRepository : IRepository<IPlayer>
    {
        private List<IPlayer> models;
        public PlayerRepository()
        {
            models = new List<IPlayer>();
        }
        public IReadOnlyCollection<IPlayer> Models => this.models.AsReadOnly();

        public void AddModel(IPlayer model)
        {
            models.Add(model);
        }
        public bool RemoveModel(string name)
        {
            IPlayer player = models.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                models.Remove(player);
                return true;
            }
            return false;
        }

        public bool ExistsModel(string name)
        {
            IPlayer player = models.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                return true;
            }
            return false;
        }

        public IPlayer GetModel(string name)
        {
            IPlayer player = models.FirstOrDefault(p => p.Name == name);
            if (player != null)
            {
                return player;
            }
            return null;
        }

       
    }
}
