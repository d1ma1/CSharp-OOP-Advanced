using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<IRepair>();
        }

        public List<IRepair> Repairs { get; set; }
        public string PartName { get; set; }
        public int HoursWorked { get; set; }

        public override string ToString()
        {
            string str = "";
            str = $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}"
                + Environment.NewLine + $"Corps: {Corps}" + Environment.NewLine + "Repairs:" + Environment.NewLine;

            foreach (var item in Repairs)
            {
                str += $"  Part Name: {item.PartName} Hours Worked: {item.HoursWorked}" + Environment.NewLine;
            }
            return str.Trim();
        }
    }
}
