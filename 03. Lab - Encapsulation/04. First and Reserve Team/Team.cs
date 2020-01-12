using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;

        public string Name { get; set; }

        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public List<Person> ReserveTeam
        {
            get { return reserveTeam; }
           
        }

        public List<Person> FirstTeam
        {
            get { return firstTeam; }
          
        }

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
           
        }

    }
}
