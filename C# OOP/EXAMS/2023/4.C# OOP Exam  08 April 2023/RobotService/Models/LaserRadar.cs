namespace RobotService.Models
{
    public class LaserRadar : Supplement
    {
        private const int INTERFACESTANDART = 20082;
        private const int BATTTERYUSAGE = 5000;

        public LaserRadar() : base(INTERFACESTANDART,BATTTERYUSAGE)
        {

        }
    }
}
