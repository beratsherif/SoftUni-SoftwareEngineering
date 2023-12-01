namespace BankLoan.Models
{
    using Contracts;
    using Utilities.Messages;
    using System;


    public abstract class Client : IClient
    {
        private string name;
        private string id;
        private double income;
        public Client(string name, string id, int interest, double income)
        {
            this.Name = name;
            this.Id = id;
            this.Interest = interest;
            this.Income = income;
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
                    throw new ArgumentException(ExceptionMessages.ClientNameNullOrWhitespace);
                }
                name = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ClientIdNullOrWhitespace);
                }
                id = value;
            }
        }

        public int Interest { get; protected set; }

        public double Income
        {
            get
            {
                return income;
            }
            private set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException(ExceptionMessages.ClientIncomeBelowZero);
                }
                income = value;
            }
        }

        public abstract void IncreaseInterest();
    }
}
