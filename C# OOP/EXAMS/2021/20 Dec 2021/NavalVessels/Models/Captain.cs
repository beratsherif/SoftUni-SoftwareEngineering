namespace NavalVessels.Models
{
    using NavalVessels.Models.Contracts;
    using NavalVessels.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class Captain : ICaptain
    {
        private string fullName;
        private Captain()
        {
            this.Vessels = new List<IVessel>();
        }
        public Captain(string fullName) : this()
        {
            this.FullName = fullName;
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.InvalidCaptainName);
                }
                fullName = value;
            }
        }

        public int CombatExperience { get; private set; }

        public ICollection<IVessel> Vessels { get; private set; }

        public void AddVessel(IVessel vessel)
        {
            if (vessel == null)
            {
                throw new NullReferenceException(ExceptionMessages.InvalidVesselForCaptain);
            }

            this.Vessels.Add(vessel);
        }

        public void IncreaseCombatExperience()
        {
            this.CombatExperience += 10;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.FullName} has {this.CombatExperience} combat experience and commands {this.Vessels.Count} vessels.");

            foreach (var vessel in Vessels)
            {
                sb.AppendLine(vessel.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
