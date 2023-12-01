namespace NavalVessels.Models
{
    using Contracts;
    using Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public abstract class Vessel : IVessel
    {
        private string name;
        private ICaptain captain;

        private Vessel() // promenihme go na private!
        {
            this.Targets = new List<string>();
        }
        protected Vessel(string name, double mainWeaponCaliber, double speed, double armorThickness) : this() // tova e protected a ne public !
        {
            this.Name = name;
            this.MainWeaponCaliber = mainWeaponCaliber;
            this.Speed = speed;
            this.ArmorThickness = armorThickness;
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException((nameof(Name)), ExceptionMessages.InvalidVesselName);
                }
                name = value;
            }
        }

        public ICaptain Captain
        {
            get
            {
                return captain;
            }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(ExceptionMessages.InvalidCaptainToVessel);
                }
                captain = value;
            }
        }
        public double ArmorThickness { get; set; }

        public double MainWeaponCaliber { get; protected set; }

        public double Speed { get; protected set; }
        public ICollection<string> Targets { get; private set; }

        public void Attack(IVessel target)
        {
            if (target == null)
            {
                throw new NullReferenceException(ExceptionMessages.InvalidTarget);
            }

            target.ArmorThickness -= this.MainWeaponCaliber;

            if (target.ArmorThickness < 0)
            {
                target.ArmorThickness = 0;
            }

            this.Targets.Add(target.Name);

            this.Captain.IncreaseCombatExperience();
            target.Captain.IncreaseCombatExperience();
        }

        public abstract void RepairVessel();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            // !!!!!!!!!!!!string targetsOutput = (Targets == null) == true ? "None" : String.Join(", ", Targets);  !!!!!!!!!!GRESHKAAAAAAA!!!!!!!!

            //string targetsOutput = this.Targets.Any() ? String.Join(", ", this.Targets) : "None";    

            string targetsOutput = this.Targets.Count == 0 ? "None" : String.Join(", ", Targets);    


            sb.AppendLine($"- {Name}");
            sb.AppendLine($" *Type: {GetType().Name}");
            sb.AppendLine($" *Armor thickness: {this.ArmorThickness}");
            sb.AppendLine($" *Main weapon caliber: {this.MainWeaponCaliber}");
            sb.AppendLine($" *Speed: {this.Speed} knots");
            sb.AppendLine($" *Targets: {targetsOutput}");

            return sb.ToString().TrimEnd();
        }
    }
}
