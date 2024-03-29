﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;

        public Player(string name,int endurance,int sprint,int dribble,int passing,int shooting)
        {
            this.Name = name;
            this.Stats = new Stats(endurance, sprint, dribble, passing, shooting);
        }
        public string Name
        {
            get { return this.name; }
            
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptionMessages.NameCannotBeNullOrWhiteSpace);
                }

                this.name = value;
            }
        }

        public Stats Stats { get; private set; }

        public double OverallRating
            => (this.Stats.Endurance + this.Stats.Sprint + this.Stats.Dribble + this.Stats.Passing + this.Stats.Shooting) / 5.0;
    }
}
