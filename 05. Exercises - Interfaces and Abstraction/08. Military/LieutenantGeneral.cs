using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<IPrivate> Privates { get; set; }
        public List<string> ListPrivateIds { get; set; }

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
            ListPrivateIds = new List<string>();
        }

        public override string ToString()
        {
            string str = "";
            str = $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}"
                + Environment.NewLine + "Privates:";

            foreach (var item in Privates)
            {
                str += Environment.NewLine + "  " + item.ToString();
            }
            return str;
        }
    }
}
