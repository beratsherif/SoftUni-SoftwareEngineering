namespace BankLoan.Repositories
{
    using Repositories.Contracts;
    using Models.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class LoanRepository : IRepository<ILoan>
    {
        private List<ILoan> loans;
        public LoanRepository()
        {
            loans = new List<ILoan>();
        }
        public IReadOnlyCollection<ILoan> Models => this.loans.AsReadOnly();

        public void AddModel(ILoan model)
        {
            loans.Add(model);
        }

        public bool RemoveModel(ILoan model)
        {
            return loans.Remove(model);
        }

        public ILoan FirstModel(string name)
        {
            ILoan currLoan;
            if (loans.Any(l => l.GetType().Name == name))
            {
                currLoan = loans.First(l => l.GetType().Name == name);
                return currLoan;
            }
            return null;
        }
    }
}
