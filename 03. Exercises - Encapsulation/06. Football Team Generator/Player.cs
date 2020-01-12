using System;

namespace FootballTeamGenerator
{
    public class Player
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
        public int Endurance { get; set; }
        public int Sprint { get; set; }
        public int Dribble { get; set; }
        public int Passing { get; set; }
        public int Shooting { get; set; }

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            if (endurance<0 || endurance>100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            if (sprint < 0 || sprint > 100) 
            {
                throw new ArgumentException("Sprint should be between 0 and 100.");
            }
            if (dribble < 0 || dribble > 100)
              
            {
                throw new ArgumentException("Dribble should be between 0 and 100.");
            }
            if (passing < 0 || passing > 100)
            {
                throw new ArgumentException("Passing should be between 0 and 100.");
            }
            if  (shooting < 0 || shooting > 100)
            {
                throw new ArgumentException("Shooting should be between 0 and 100.");
            }
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public double GetRaiting()
        {
            return ((Endurance + Dribble + Passing + Shooting + Sprint) / 5.0);
        }
    }
}
