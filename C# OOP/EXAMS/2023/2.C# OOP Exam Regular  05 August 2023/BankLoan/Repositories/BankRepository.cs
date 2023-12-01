namespace BankLoan.Repositories
{
    using Repositories.Contracts;
    using Models.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    public class BankRepository : IRepository<IBank>
    {
        private List<IBank> banks;
        public BankRepository()
        {
            banks = new List<IBank>();
        }
        public IReadOnlyCollection<IBank> Models => this.banks.AsReadOnly();

        public void AddModel(IBank model)
        {
            banks.Add(model);
        }
        public bool RemoveModel(IBank model)
        {
            return banks.Remove(model);
        }

        public IBank FirstModel(string name)
        {
            return banks.First(b => b.Name == name);
        }
    }
}
