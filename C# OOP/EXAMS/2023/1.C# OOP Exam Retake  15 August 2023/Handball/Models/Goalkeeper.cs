namespace Handball.Models
{
    public class Goalkeeper : Player
    {
        private const double  INITIAL_RATING_VALUE = 2.5;
        public Goalkeeper(string name) : base(name, INITIAL_RATING_VALUE)
        {

        }
        public override void DecreaseRating()
        {
            Rating -= 1.25;
        }

        public override void IncreaseRating()
        {
            Rating += 0.75;
        }
    }
}
