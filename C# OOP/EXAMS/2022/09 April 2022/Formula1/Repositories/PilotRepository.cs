﻿namespace Formula1.Repositories
{
    using Formula1.Models.Contracts;
    using Formula1.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;


    public class PilotRepository : IRepository<IPilot>
    {
        private  List<IPilot> models;
        public PilotRepository()
        {
            this.models = new List<IPilot>();
        }
        public IReadOnlyCollection<IPilot> Models => this.models.AsReadOnly();

        public void Add(IPilot model)
        {
            models.Add(model);
        }

        public IPilot FindByName(string name)
        {
            return models.FirstOrDefault(m => m.FullName == name);
        }

        public bool Remove(IPilot model)
        {
            return models.Remove(model);
        }
    }
}
