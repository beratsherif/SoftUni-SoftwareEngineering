namespace Handball.Models
{
    using Handball.Models.Contracts;
    using Handball.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Team : ITeam
    {
        private string name;
        private List<IPlayer> players;
        public Team(string name)
        {
            this.Name = name;
            players = new List<IPlayer>();
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
                    throw new ArgumentException(ExceptionMessages.TeamNameNull);
                }
                name = value;
            }
        }

        public int PointsEarned { get; private set; }

        public double OverallRating => Math.Round(players.Sum(p => p.Rating / players.Count), 2);

        public IReadOnlyCollection<IPlayer> Players => this.players.AsReadOnly();

        public void SignContract(IPlayer player)
        {
            players.Add(player);
        }

        public void Win()
        {
            this.PointsEarned += 3;

            foreach (var player in players)
            {
                player.IncreaseRating();
            }
        }

        public void Lose()
        {
            foreach (var player in players)
            {
                player.DecreaseRating();
            }
        }

        public void Draw()
        {
            this.PointsEarned += 1;



            IPlayer goalKeeper = players.First(p => p.GetType().Name == nameof(Goalkeeper));

            goalKeeper.IncreaseRating();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Team: {Name} Points: {PointsEarned}");
            sb.AppendLine($"--Overall rating: {OverallRating}");



            List<string> names = new List<string>();
            foreach (var player in players)
            {
                names.Add(player.Name);
            }
            string playerNames = names.Any() ? string.Join(", ", names) : "none";

            sb.AppendLine($"--Players: {playerNames}");

            return sb.ToString().TrimEnd();
        }
    }
}
