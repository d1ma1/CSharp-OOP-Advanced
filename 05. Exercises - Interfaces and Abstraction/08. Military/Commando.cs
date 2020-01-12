using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando, IMission
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Mission = new List<IMission>();
        }

        public List<IMission> Mission { get; set;}
        public string CodeName { get; set;}
        public string State { get; set;}

        public override string ToString()
        {
            string str = "";
            str = $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}"
                + Environment.NewLine + $"Corps: {Corps}" + Environment.NewLine + "Missions:";

            foreach (var item in Mission)
            {
                str += Environment.NewLine + $"  Code Name: {item.CodeName} State: {item.State}";
            }
            return str.Trim();
        }
    }
}
