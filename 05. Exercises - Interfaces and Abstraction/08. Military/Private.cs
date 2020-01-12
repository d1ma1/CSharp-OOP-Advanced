using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private : IPrivate
    {
        public decimal Salary { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Private(string id, string firstName, string lastName, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName =lastName;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}".Trim();
        }
    }
}
