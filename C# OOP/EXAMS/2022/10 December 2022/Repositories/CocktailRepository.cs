﻿namespace ChristmasPastryShop.Repositories
{
    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Repositories.Contracts;
    using System.Collections.Generic;
    public class CocktailRepository : IRepository<ICocktail>
    {
        private List<ICocktail> models;
        public CocktailRepository()
        {
            models = new List<ICocktail>();
        }
        public IReadOnlyCollection<ICocktail> Models => models.AsReadOnly();

        public void AddModel(ICocktail model)
        {
            models.Add(model);
        }
    }
}
