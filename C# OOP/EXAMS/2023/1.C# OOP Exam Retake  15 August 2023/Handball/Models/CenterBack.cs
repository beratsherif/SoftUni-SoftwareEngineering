namespace Handball.Models
{
    public class CenterBack : Player
    {
        private const double INITIAL_RATING_VALUE = 4;
        public CenterBack(string name) : base(name, INITIAL_RATING_VALUE)
        {

        }
        public override void DecreaseRating()
        {
            Rating -= 1;
        }

        public override void IncreaseRating()
        {
            Rating += 1;
        }
    }
}
