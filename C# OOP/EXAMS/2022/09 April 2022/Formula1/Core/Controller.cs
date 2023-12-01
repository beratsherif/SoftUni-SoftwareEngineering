namespace Formula1.Core
{
    using Formula1.Core.Contracts;
    using Formula1.Models;
    using Formula1.Models.Contracts;
    using Formula1.Repositories;
    using Formula1.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository formulaOneCarRepository;

        public Controller()
        {
            pilotRepository = new PilotRepository();
            raceRepository = new RaceRepository();
            formulaOneCarRepository = new FormulaOneCarRepository();
        }
        public string CreatePilot(string fullName)
        {
            if (pilotRepository.FindByName(fullName) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.PilotExistErrorMessage, fullName));
            }
            else
            {
                IPilot pilot = new Pilot(fullName);
                pilotRepository.Add(pilot);
                return string.Format(OutputMessages.SuccessfullyCreatePilot, fullName);
            }
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (formulaOneCarRepository.FindByName(model) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.CarExistErrorMessage, model));
            }
            if (type == "Ferrari")
            {
                IFormulaOneCar car = new Ferrari(model, horsepower, engineDisplacement);
                formulaOneCarRepository.Add(car);
                return string.Format(OutputMessages.SuccessfullyCreateCar, type, model);
            }
            else if (type == "Williams")
            {
                IFormulaOneCar car = new Williams(model, horsepower, engineDisplacement);
                formulaOneCarRepository.Add(car);
                return string.Format(OutputMessages.SuccessfullyCreateCar, type, model);
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidTypeCar, type));
            }
        }


        public string CreateRace(string raceName, int numberOfLaps)
        {
            if (raceRepository.FindByName(raceName) != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExistErrorMessage, raceName));
            }
            else
            {
                IRace race = new Race(raceName, numberOfLaps);
                raceRepository.Add(race);
                return string.Format(OutputMessages.SuccessfullyCreateRace, raceName);
            }
        }


        public string AddCarToPilot(string pilotName, string carModel)
        {
            if (pilotRepository.FindByName(pilotName) == null || pilotRepository.FindByName(pilotName).Car != null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.PilotDoesNotExistOrHasCarErrorMessage, pilotName));
            }
            if (formulaOneCarRepository.FindByName(carModel) == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages.CarDoesNotExistErrorMessage, carModel));
            }

            IFormulaOneCar car = formulaOneCarRepository.FindByName(carModel);
            pilotRepository.FindByName(pilotName).AddCar(car);
            formulaOneCarRepository.Remove(car);

            return string.Format(OutputMessages.SuccessfullyPilotToCar, pilotName, car.GetType().Name, carModel);


        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            IRace race = raceRepository.FindByName(raceName);
            IPilot pilot = pilotRepository.FindByName(pilotFullName);

            if (race == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }
            if (pilot == null || pilot.CanRace == false || race.Pilots.Contains(pilot))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.PilotDoesNotExistErrorMessage, pilotFullName, raceName));
            }

            race.AddPilot(pilot);
            return string.Format(OutputMessages.SuccessfullyAddPilotToRace, pilotFullName, raceName);
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.FindByName(raceName);

            if (race == null)
            {
                throw new NullReferenceException(string.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }
            if (race.Pilots.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRaceParticipants, raceName));
            }
            if (race.TookPlace)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceTookPlaceErrorMessage, raceName));
            }

            List<IPilot> orderedPilots = race.Pilots.OrderByDescending(p => p.Car.RaceScoreCalculator(race.NumberOfLaps)).ToList();
            race.TookPlace = true;
            orderedPilots[0].WinRace();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pilot {orderedPilots[0].FullName} wins the {raceName} race.");
            sb.AppendLine($"Pilot {orderedPilots[1].FullName} is second in the {raceName} race.");
            sb.AppendLine($"Pilot {orderedPilots[2].FullName} is third in the {raceName} race.");

            return sb.ToString().TrimEnd();
        }
        public string PilotReport()
        {
            List<IPilot> pilots = pilotRepository.Models.OrderByDescending(p => p.NumberOfWins).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var pilot in pilots)
            {
                sb.AppendLine(pilot.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string RaceReport()
        {
            List<IRace> races = raceRepository.Models.Where(r => r.TookPlace).ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var race in races)
            {
                sb.AppendLine(race.RaceInfo());
            }

            return sb.ToString().TrimEnd();
        }

        
    }
}
