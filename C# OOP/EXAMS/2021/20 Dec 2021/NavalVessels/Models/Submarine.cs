namespace NavalVessels.Models
{
    using NavalVessels.Models.Contracts;
    using System.Text;


    public class Submarine : Vessel, ISubmarine
    {
        private const double INITIAL_ARMOR_THICKNESS = 200;
        public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, INITIAL_ARMOR_THICKNESS)
        {
            SubmergeMode = false;
        }
        public bool SubmergeMode { get; private set; }

        public override void RepairVessel()
        {
            this.ArmorThickness = INITIAL_ARMOR_THICKNESS;
        }

        public void ToggleSubmergeMode()
        {
            //if (SubmergeMode)
            //{
            //    MainWeaponCaliber -= 40;
            //    Speed += 4;
            //}

            //MainWeaponCaliber += 40;
            //Speed -= 4;

            //this.SubmergeMode = !SubmergeMode;




            if (!this.SubmergeMode)
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 4;
            }
            else
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 4;
            }

            this.SubmergeMode = !this.SubmergeMode;
        }
        public override string ToString()
        {
            string submergeMode = SubmergeMode == true ? "ON" : "OFF";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Submerge mode: {submergeMode}");

            return sb.ToString().TrimEnd();
        }
    }
}
