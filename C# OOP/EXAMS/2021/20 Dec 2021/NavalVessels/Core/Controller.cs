
namespace NavalVessels.Core
{
    using NavalVessels.Core.Contracts;
    using NavalVessels.Models;
    using NavalVessels.Models.Contracts;
    using NavalVessels.Repositories;
    using NavalVessels.Repositories.Contracts;
    using NavalVessels.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Controller : IController
    {
        private readonly IRepository<IVessel> vessels;
        private readonly ICollection<ICaptain> captains;

        public Controller()
        {
            this.vessels = new VesselRepository();
            this.captains = new HashSet<ICaptain>();
        }

        public string HireCaptain(string fullName)                       //PROVERI TUK !!!! namerena greshka tuk ne moje s contains!
        {
            ICaptain currCaptain = new Captain(fullName);

            if (captains.Any(c => c.FullName == fullName))
            {
                return String.Format(OutputMessages.CaptainIsAlreadyHired, fullName);
            }

            captains.Add(currCaptain);
            return String.Format(OutputMessages.SuccessfullyAddedCaptain, fullName);
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            IVessel existingVessel = this.vessels.FindByName(name);
            if (existingVessel != null)
            {
                return String.Format(OutputMessages.VesselIsAlreadyManufactured, existingVessel.GetType().Name, name);
            }

            IVessel producedVessel;
            if (vesselType == "Submarine")
            {
                producedVessel = new Submarine(name, mainWeaponCaliber, speed);
            }
            else if (vesselType == "Battleship")
            {
                producedVessel = new Battleship(name, mainWeaponCaliber, speed);
            }
            else
            {
                return OutputMessages.InvalidVesselType;
            }

            vessels.Add(producedVessel);
            return string.Format(OutputMessages.SuccessfullyCreateVessel,vesselType,name,mainWeaponCaliber,speed);
        }

        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            ICaptain captain = captains.FirstOrDefault(c => c.FullName == selectedCaptainName);
            IVessel vessel = vessels.FindByName(selectedVesselName);

            if (captain == null)
            {
                return string.Format(OutputMessages.CaptainNotFound,selectedCaptainName);
            }
            if (vessel == null)
            {
                return string.Format(OutputMessages.VesselNotFound, selectedVesselName);
            }
            if (vessel.Captain != null)
            {
                return string.Format(OutputMessages.VesselOccupied, selectedVesselName);
            }

            vessel.Captain = captain;
            captain.AddVessel(vessel);
            return string.Format(OutputMessages.SuccessfullyAssignCaptain,selectedCaptainName,selectedVesselName);
        }

        public string CaptainReport(string captainFullName)
        {
            ICaptain captain = captains.First(c => c.FullName == captainFullName);

            return captain.Report();
        }

        public string VesselReport(string vesselName)
        {
            IVessel vessel = vessels.FindByName(vesselName);
             return vessel?.ToString();
        }

        public string ToggleSpecialMode(string vesselName)
        {
            IVessel vessel = vessels.FindByName(vesselName);

            if (vessel == null)
            {
                return string.Format(OutputMessages.VesselNotFound, vesselName);
            }

            if (vessel.GetType() == typeof(Battleship))
            {
                Battleship battleship = (Battleship)vessel;
                battleship.ToggleSonarMode();

                return string.Format(OutputMessages.ToggleBattleshipSonarMode, vesselName);
            }
            else
            {
                Submarine submarine = (Submarine)vessel;
                submarine.ToggleSubmergeMode();

                return string.Format(OutputMessages.ToggleSubmarineSubmergeMode, vesselName);
            }
           
        }

        public string ServiceVessel(string vesselName)
        {
            IVessel vessel = vessels.FindByName(vesselName);

            if (vessel == null)
            {
                return string.Format(OutputMessages.VesselNotFound, vesselName);
            }

            vessel.RepairVessel();
            return string.Format(OutputMessages.SuccessfullyRepairVessel, vesselName);
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            IVessel atackingVessel = vessels.FindByName(attackingVesselName);

            if (atackingVessel == null)
            {
                return string.Format(OutputMessages.VesselNotFound, attackingVesselName);
            }


            IVessel defendingVessel = vessels.FindByName(defendingVesselName);

            if (defendingVessel == null)
            {
                return string.Format(OutputMessages.VesselNotFound, defendingVesselName);
            }
            if (atackingVessel.ArmorThickness == 0)
            {
                return string.Format(OutputMessages.AttackVesselArmorThicknessZero, attackingVesselName);
            }
            if (defendingVessel.ArmorThickness == 0)
            {
                return string.Format(OutputMessages.AttackVesselArmorThicknessZero, defendingVesselName);
            }

            atackingVessel.Attack(defendingVessel);

            return string.Format(OutputMessages.SuccessfullyAttackVessel, defendingVesselName, attackingVesselName, defendingVessel.ArmorThickness);
        }
    }
}
