namespace RobotService.Models
{
    public class SpecializedArm : Supplement
    {
        private const int INTERFACESTANDART = 10045;
        private const int BATTERYUSAGE = 10000;
        public SpecializedArm() : base(INTERFACESTANDART,BATTERYUSAGE)
        {

        }
    }
}
