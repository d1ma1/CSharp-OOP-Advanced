using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Spy : ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} "+Environment.NewLine+$"Code Number: {CodeNumber}".Trim();
        }
    }
}
