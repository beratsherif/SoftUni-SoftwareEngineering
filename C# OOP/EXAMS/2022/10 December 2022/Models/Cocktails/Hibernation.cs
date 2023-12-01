namespace ChristmasPastryShop.Models.Cocktails
{
    public class Hibernation : Cocktail
    {
        private const double LARGE_HIBERNATION_PRICE = 10.5;

        public Hibernation(string cocktailName, string size) : base(cocktailName,size,LARGE_HIBERNATION_PRICE)
        {

        }
    }
}
