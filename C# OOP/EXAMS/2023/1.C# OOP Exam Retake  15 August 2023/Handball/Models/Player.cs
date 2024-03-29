﻿namespace Handball.Models
{
    using Handball.Models.Contracts;
    using Handball.Utilities.Messages;
    using System;
    using System.Text;
    public abstract class Player : IPlayer
    {
        private string name;
        public Player(string name, double rating)
        {
            this.Name = name;
            this.Rating = rating;
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.PlayerNameNull);
                }
                name = value;
            }
        }

        public double Rating { get; protected set; }

        public string Team { get; protected set; }

        public  void JoinTeam(string name)
        {
            this.Team = name;
        }
        public abstract void IncreaseRating();
        public abstract void DecreaseRating();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{GetType().Name}: {this.Name}");
            sb.AppendLine($"--Rating: {this.Rating}");

            return sb.ToString().TrimEnd();
        }
    }
}
