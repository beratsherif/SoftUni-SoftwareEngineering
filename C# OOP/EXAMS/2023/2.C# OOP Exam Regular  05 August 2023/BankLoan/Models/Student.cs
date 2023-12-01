namespace BankLoan.Models
{

    public class Student : Client
    {
        private const int INITIAL_INTEREST = 2;
        public Student(string name, string id, double income) : base(name, id, INITIAL_INTEREST, income)
        {

        }
        public override void IncreaseInterest()
        {
            this.Interest += 1;
        }
    }
}
