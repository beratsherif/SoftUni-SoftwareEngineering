namespace RobotService.Models
{
    public class DomesticAssistant : Robot
    {
        private const int CURR_BATTERY_CAPACITY = 20000;
        private const int CURR_CONVERTION_CAPACITY_INDEX = 2000;
        public DomesticAssistant(string model) : base(model, CURR_BATTERY_CAPACITY, CURR_CONVERTION_CAPACITY_INDEX)
        {

        }
    }
}
