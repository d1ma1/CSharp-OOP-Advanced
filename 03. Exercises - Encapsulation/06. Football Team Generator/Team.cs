using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                   throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public List<Player> Players { get; set; }
        private double Raiting { get; set; }

        public Team()
        {
            this.Players = new List<Player>();
        }
        public Team(string name, double raiting)
        {
            this.Name = name;
            this.Raiting = raiting;
            this.Players = new List<Player>();
        }

        public double GetTeamRaiting()
        {
            var sum = 0.0;

            foreach (var item in Players)
            {
                sum += item.GetRaiting();
            }

            return Math.Round(sum);
        }

        public bool isInside(string playerName)
        {
            var isIn = false;
            foreach (var item in Players)
            {
                if (item.Name == playerName)
                {
                    isIn = true;
                }
            }
            return isIn;
        }
    }
}
