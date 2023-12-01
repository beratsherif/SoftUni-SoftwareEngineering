namespace BankLoan.Models
{
    public class MortgageLoan : Loan
    {
        private const int INTERESTED_RATE = 3;
        private const double AMOUNT = 50000;
        public MortgageLoan() : base(INTERESTED_RATE, AMOUNT)
        {

        }
    }
}
