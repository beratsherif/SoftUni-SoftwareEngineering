namespace ChristmasPastryShop.Models.Delicacies
{
    public class Stolen : Delicacy
    {
        private const double CURR_PRICE = 3.5;

        public Stolen(string delicacyName) : base(delicacyName,CURR_PRICE)
        {

        }
    }
}
