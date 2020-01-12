using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Child> Children { get; set; }

        public Person(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
            Parents = new List<Parent>();
            Children = new List<Child>();
        }
    }
}
