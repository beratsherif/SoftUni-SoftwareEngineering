﻿namespace BankLoan.Models
{
    public class Adult : Client
    {
        private const int INITIAL_INTEREST = 4;
        public Adult(string name, string id, double income) : base(name, id, INITIAL_INTEREST, income)
        {

        }
        public override void IncreaseInterest()
        {
            this.Interest += 2;
        }
    }
}
