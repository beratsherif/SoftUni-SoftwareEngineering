namespace Formula1.Repositories
{
    using Formula1.Models.Contracts;
    using Formula1.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;


    public class FormulaOneCarRepository : IRepository<IFormulaOneCar>
    {
        private  readonly List<IFormulaOneCar> models; // Proveri tuk moje da ima greshka s readonly!
        public FormulaOneCarRepository()
        {
            models = new List<IFormulaOneCar>();
        }
        public IReadOnlyCollection<IFormulaOneCar> Models => this.models.AsReadOnly();

        public void Add(IFormulaOneCar model)
        {
            models.Add(model);
        }

        public IFormulaOneCar FindByName(string name)
        {
            return models.FirstOrDefault(m => m.Model == name);
        }

        public bool Remove(IFormulaOneCar model)
        {
            return models.Remove(model);
        }
    }
}
