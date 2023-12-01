namespace Handball.Models
{
    public class ForwardWing : Player
    {
        private const double INITIAL_RATING_VALUE = 5.5;
        public ForwardWing(string name) : base(name, INITIAL_RATING_VALUE)
        {

        }
        public override void DecreaseRating()
        {
            Rating -= 0.75;
        }

        public override void IncreaseRating()
        {
            Rating += 1.25;
        }
    }
}
