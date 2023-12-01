namespace BankLoan.Models
{


    public class StudentLoan : Loan
    {
        private const int INTERESTED_RATE = 1;
        private const double AMOUNT = 10000;
        public StudentLoan() : base(INTERESTED_RATE,AMOUNT)
        {

        }
    }
}
