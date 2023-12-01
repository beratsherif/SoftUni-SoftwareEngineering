namespace NavalVessels.Models
{
    using NavalVessels.Models.Contracts;
    using System.Text;

    public class Battleship : Vessel, IBattleship
    {
        private const double INITIAL_ARMOR_THICKNESS = 300;

        public Battleship(string name, double mainWeaponCaliber, double speed) : base(name,mainWeaponCaliber,speed,INITIAL_ARMOR_THICKNESS)
        {
            SonarMode = false;
        }
        public bool SonarMode { get; private set; }

        public override void RepairVessel()
        {
            this.ArmorThickness = INITIAL_ARMOR_THICKNESS;
        }

        public void ToggleSonarMode()
        {
            //if (SonarMode)
            //{
            //    MainWeaponCaliber -= 40;
            //    Speed += 5;
            //}

            //MainWeaponCaliber += 40;
            //Speed -= 5;

            //this.SonarMode = !SonarMode;




            if (!this.SonarMode)
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 5;
            }
            else
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 5;
            }

            this.SonarMode = !this.SonarMode;
        }






        public override string ToString()
        {
            string sonarMode = SonarMode == true ? "ON" : "OFF";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($" *Sonar mode: {sonarMode}");

            return sb.ToString().TrimEnd();
        }
    }
}
