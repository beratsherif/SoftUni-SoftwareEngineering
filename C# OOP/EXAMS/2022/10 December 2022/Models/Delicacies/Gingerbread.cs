namespace ChristmasPastryShop.Models.Delicacies
{
    public class Gingerbread : Delicacy
    {
        private const double CURR_PRICE = 4;

        public Gingerbread(string delicacyName) : base(delicacyName,CURR_PRICE)
        {

        }
    }
}
