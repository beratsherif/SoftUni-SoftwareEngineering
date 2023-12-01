namespace BankLoan.Core
{
    using BankLoan.Core.Contracts;
    using BankLoan.Models;
    using BankLoan.Models.Contracts;
    using BankLoan.Repositories;
    using BankLoan.Utilities.Messages;
    using System;
    using System.Text;

    public class Controller : IController
    {
        private LoanRepository loans;
        private BankRepository banks;
        public Controller()
        {
            loans = new LoanRepository();
            banks = new BankRepository();
        }
        public string AddBank(string bankTypeName, string name)
        {
            IBank currBank;
            if (bankTypeName == "BranchBank")
            {
                currBank = new BranchBank(name);
            }
            else if (bankTypeName == "CentralBank")
            {
                currBank = new CentralBank(name);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.BankTypeInvalid);
            }

            banks.AddModel(currBank);
            return string.Format(OutputMessages.BankSuccessfullyAdded, currBank.GetType().Name);
        }

        public string AddLoan(string loanTypeName)
        {
            ILoan loan;
            if (loanTypeName == "StudentLoan")
            {
                loan = new StudentLoan();
            }
            else if (loanTypeName == "MortgageLoan")
            {
                loan = new MortgageLoan();
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.LoanTypeInvalid);
            }

            loans.AddModel(loan);
            return string.Format(OutputMessages.LoanSuccessfullyAdded, loan.GetType().Name);
        }

        public string ReturnLoan(string bankName, string loanTypeName)
        {
            ILoan currLoan = loans.FirstModel(loanTypeName);
            if (currLoan == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.MissingLoanFromType, loanTypeName));
            }

            IBank currBank = banks.FirstModel(bankName);
            currBank.AddLoan(currLoan);
            this.loans.RemoveModel(currLoan);

            return string.Format(OutputMessages.LoanReturnedSuccessfully, loanTypeName, bankName);
        }

        public string AddClient(string bankName, string clientTypeName, string clientName, string id, double income)
        {
            if (clientTypeName != "Student" && clientTypeName != "Adult")
            {
                throw new ArgumentException(ExceptionMessages.ClientTypeInvalid);
            }
            IBank currBank = banks.FirstModel(bankName);

            if (currBank.GetType().Name == "BranchBank" && clientTypeName == "Student")
            {
                IClient currClient = new Student(clientName, id, income);
                currBank.AddClient(currClient);
                return string.Format(OutputMessages.ClientAddedSuccessfully, clientTypeName, bankName);
            }
            else if (currBank.GetType().Name == "CentralBank" && clientTypeName == "Adult")
            {
                IClient currClient = new Adult(clientName, id, income);
                currBank.AddClient(currClient);
                return string.Format(OutputMessages.ClientAddedSuccessfully, clientTypeName, bankName);
            }
            else
            {
                return OutputMessages.UnsuitableBank;
            }
        }

        public string FinalCalculation(string bankName)
        {
            IBank currBank = banks.FirstModel(bankName);


            double fundsSum = 0;

            foreach (var loan in currBank.Loans)
            {
                fundsSum += loan.Amount;
            }
            foreach (var client in currBank.Clients)
            {
                fundsSum += client.Income;
            }

            return string.Format(OutputMessages.BankFundsCalculated, bankName, $"{fundsSum:F2}");

        }

        public string Statistics()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var bank in banks.Models)
            {
                sb.AppendLine(bank.GetStatistics());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
