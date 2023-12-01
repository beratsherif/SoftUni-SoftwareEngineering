namespace RobotService.Core
{
    using System;
    using System.Text;
    using Core.Contracts;
    using Models;
    using Models.Contracts;
    using Repositories;
    using Utilities.Messages;
    using System.Linq;

    public class Controller : IController
    {
        private SupplementRepository suplements;
        private RobotRepository robots;
        public Controller()
        {
            this.suplements = new SupplementRepository();
            this.robots = new RobotRepository();
        }
        public string CreateRobot(string model, string typeName)
        {
            IRobot currRobot;
            if (typeName == "DomesticAssistant")
            {
                currRobot = new DomesticAssistant(model) ;
            }
            else if (typeName == "IndustrialAssistant")
            {
                currRobot = new IndustrialAssistant(model);
            }
            else
            {
                return string.Format(OutputMessages.RobotCannotBeCreated, typeName);
            }

            robots.AddNew(currRobot);
            return string.Format(OutputMessages.RobotCreatedSuccessfully, typeName, model);
        }

        public string CreateSupplement(string typeName)
        {
            ISupplement currSupp;
            if (typeName == "SpecializedArm")
            {
                currSupp = new SpecializedArm();
            }
            else if (typeName == "LaserRadar")
            {
                currSupp = new LaserRadar();
            }
            else
            {
                return string.Format(OutputMessages.SupplementCannotBeCreated, typeName);
            }

            suplements.AddNew(currSupp);
            return string.Format(OutputMessages.SupplementCreatedSuccessfully, typeName);
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            ISupplement currSup = suplements.Models().First(s => s.GetType().Name == supplementTypeName);
            int currInterfaceValue = currSup.InterfaceStandard;

            var currRobotsNotSupportingInterfacesAndWithSameModelName = robots.Models().Where(r => !r.InterfaceStandards.Contains(currInterfaceValue) && r.Model == model);

           
            if (!currRobotsNotSupportingInterfacesAndWithSameModelName.Any())
            {
                return string.Format(OutputMessages.AllModelsUpgraded, model);
            }
            else
            {
                IRobot currRob = currRobotsNotSupportingInterfacesAndWithSameModelName.First();
                currRob.InstallSupplement(currSup);

                suplements.RemoveByName(currSup.GetType().Name);
                return string.Format(OutputMessages.UpgradeSuccessful, model, currSup.GetType().Name);
            }
        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            var neededRobots = robots.Models().Where(r => r.InterfaceStandards.Contains(intefaceStandard)).OrderByDescending(r => r.BatteryLevel);
            if (!neededRobots.Any())
            {
                return string.Format(OutputMessages.UnableToPerform, intefaceStandard);
            }

            var sumOfBatLevelOfSellectedRobots = neededRobots.Sum(r => r.BatteryLevel);
            if (sumOfBatLevelOfSellectedRobots < totalPowerNeeded)
            {
                return string.Format(OutputMessages.MorePowerNeeded, serviceName, (totalPowerNeeded - sumOfBatLevelOfSellectedRobots));
            }

            int counter = 0;

            foreach (var robot in neededRobots)
            {
                if (robot.BatteryLevel >= totalPowerNeeded)
                {
                    robot.ExecuteService(totalPowerNeeded);
                    counter++;
                    break;
                }
                else
                {
                    totalPowerNeeded -= robot.BatteryLevel;
                    robot.ExecuteService(robot.BatteryLevel);
                    counter++;
                }
            }
            return string.Format(OutputMessages.PerformedSuccessfully, serviceName, counter);
        }
        public string RobotRecovery(string model, int minutes)
        {
            var robotsUnder50 = robots.Models().Where(r => r.Model == model && r.BatteryLevel < r.BatteryCapacity / 2);

            int counter = 0;

            foreach (var robot in robotsUnder50)
            {
                robot.Eating(minutes);
                counter++;
            }

            return string.Format(OutputMessages.RobotsFed, counter);
        }

        public string Report()
        {
            var currRobots = robots.Models().OrderByDescending(r => r.BatteryLevel).ThenBy(r => r.BatteryCapacity);
            StringBuilder sbb = new StringBuilder();

            foreach (var robot in currRobots)
            {
                sbb.AppendLine(robot.ToString());
            }


            return sbb.ToString().TrimEnd();
        }
    }
}
