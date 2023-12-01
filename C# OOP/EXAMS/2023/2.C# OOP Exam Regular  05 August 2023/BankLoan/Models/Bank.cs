namespace BankLoan.Models
{
    using BankLoan.Utilities.Messages;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public abstract class Bank : IBank
    {
        private string name;
        private List<ILoan> loans;
        private List<IClient> clients;
        public Bank(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            loans = new List<ILoan>();
            clients = new List<IClient>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BankNameNullOrWhiteSpace);
                }
                name = value;
            }
        }
        public int Capacity { get; private set; }

        public IReadOnlyCollection<ILoan> Loans => this.loans.AsReadOnly();

        public IReadOnlyCollection<IClient> Clients => this.clients.AsReadOnly();

        public double SumRates()
        {
            double sumOfInterestRates = 0;
            foreach (var loan in loans)
            {
                sumOfInterestRates += loan.InterestRate;
            }

            return sumOfInterestRates;
        }

        public void AddClient(IClient Client)
        {
            if (clients.Count < this.Capacity)
            {
                clients.Add(Client);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughCapacity);
            }
        }
        public void RemoveClient(IClient Client)
        {
            clients.Remove(Client);
        }

        public void AddLoan(ILoan loan)
        {
            loans.Add(loan);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {Name}, Type: {GetType().Name}");

            List<string> currClientsNames = new List<string>();
            foreach (var client in clients)
            {
                currClientsNames.Add(client.Name);
            }
            string clientsNamesOutput = currClientsNames.Any() ? string.Join(", ", currClientsNames) : "none";
            sb.AppendLine($"Clients: {clientsNamesOutput}");


            int sumOfLoans = 0;
            foreach (var loan in loans)
            {
                sumOfLoans += loan.InterestRate;
            }
            sb.AppendLine($"Loans: {loans.Count}, Sum of Rates: {sumOfLoans}");

            return sb.ToString().TrimEnd();
        }
        
    }
}
