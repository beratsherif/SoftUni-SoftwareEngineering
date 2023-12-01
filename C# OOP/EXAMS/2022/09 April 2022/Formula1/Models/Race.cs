namespace Formula1.Models
{
    using Formula1.Models.Contracts;
    using Formula1.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Race : IRace
    {
        string raceName;
        int numberOfLaps;
        private ICollection<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;

            this.TookPlace = false;
            this.pilots = new List<IPilot>();
        }

        public string RaceName
        {
            get
            {
                return raceName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidRaceName, value));
                }

                raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get
            {
                return numberOfLaps;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidLapNumbers, value));
                }

                numberOfLaps = value;
            }
        }

        public bool TookPlace { get; set; }


        public ICollection<IPilot> Pilots
        {
            get { return pilots; }
        }



        public void AddPilot(IPilot pilot)
        {
            this.Pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            StringBuilder sb = new StringBuilder();

            string tookPlace = this.TookPlace ? "Yes" : "No";

            sb.AppendLine($"The {this.raceName} race has:");
            sb.AppendLine($"Participants: {this.Pilots.Count}");
            sb.AppendLine($"Number of laps: {this.numberOfLaps}");
            sb.AppendLine($"Took place: {tookPlace}");

            return sb.ToString().TrimEnd();
        }
    }
}
