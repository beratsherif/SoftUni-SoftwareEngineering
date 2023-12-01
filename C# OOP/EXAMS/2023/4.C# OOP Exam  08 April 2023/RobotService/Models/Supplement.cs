namespace RobotService.Models
{
    using Models.Contracts;

    public abstract class Supplement : ISupplement
    {
        public Supplement(int interfaceStandard, int batteryUsage)
        {
            this.InterfaceStandard = interfaceStandard;
            this.BatteryUsage = batteryUsage;
        }
        public int InterfaceStandard { get; private set; }

        public int BatteryUsage { get; private set; }
    }
}
