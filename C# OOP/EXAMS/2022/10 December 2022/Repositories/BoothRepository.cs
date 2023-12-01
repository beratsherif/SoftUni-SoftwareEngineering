namespace ChristmasPastryShop.Repositories
{
    using ChristmasPastryShop.Models.Booths.Contracts;
    using ChristmasPastryShop.Repositories.Contracts;
    using System.Collections.Generic;

    public class BoothRepository : IRepository<IBooth>
    {
        private List<IBooth> models;
        public BoothRepository()
        {
            models = new List<IBooth>();
        }
        public IReadOnlyCollection<IBooth> Models => models.AsReadOnly();

        public void AddModel(IBooth model)
        {
            models.Add(model);
        }
    }
}
