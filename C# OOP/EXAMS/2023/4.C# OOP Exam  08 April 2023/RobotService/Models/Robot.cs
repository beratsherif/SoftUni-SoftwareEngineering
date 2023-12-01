namespace RobotService.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Models.Contracts;
    using Utilities.Messages;


    public abstract class Robot : IRobot
    {
        private string model;
        private int batteryCapacity;
        private List<int> interfaceStandarts;

        public Robot(string model, int batteryCapacity, int conversionCapacityIndex)
        {
            this.Model = model;
            this.BatteryCapacity = batteryCapacity;
            this.ConvertionCapacityIndex = conversionCapacityIndex;
            this.interfaceStandarts = new List<int>();
            this.BatteryLevel = batteryCapacity;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNullOrWhitespace);
                }

                this.model = value;
            }
        }

        public int BatteryCapacity
        {
            get
            {
                return this.batteryCapacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.BatteryCapacityBelowZero);
                }
                this.batteryCapacity = value;
            }
        }

        public int BatteryLevel { get; private set; }

        public int ConvertionCapacityIndex { get; private set; }

        public IReadOnlyCollection<int> InterfaceStandards => this.interfaceStandarts.AsReadOnly();

        public void Eating(int minutes)
        {
            //for (int i = 0; i < minutes; i++)
            //{
            //    if (this.BatteryLevel == this.BatteryCapacity)
            //    {
            //        break;
            //    }
            //    this.BatteryLevel += this.ConvertionCapacityIndex;
            //}
            if (this.ConvertionCapacityIndex * minutes > this.BatteryCapacity)
            {
                this.BatteryLevel = this.BatteryCapacity;
            }
            else
            {
                this.BatteryLevel += this.ConvertionCapacityIndex * minutes;
            }
        }
        public void InstallSupplement(ISupplement supplement)
        {
            this.interfaceStandarts.Add(supplement.InterfaceStandard);
            this.BatteryCapacity -= supplement.BatteryUsage;
            this.BatteryLevel -= supplement.BatteryUsage;
        }
        public bool ExecuteService(int consumedEnergy)
        {
            if (consumedEnergy <= this.BatteryLevel)
            {
                this.BatteryLevel -= consumedEnergy;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name} {this.model}:");
            sb.AppendLine($"--Maximum battery capacity: {this.BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {this.BatteryLevel}");

            string suplementInstalledHave = interfaceStandarts.Any() ? string.Join(" ", interfaceStandarts) : "none";
            sb.AppendLine($"--Supplements installed: {suplementInstalledHave}");

            return sb.ToString().TrimEnd();
        }

    }
}
