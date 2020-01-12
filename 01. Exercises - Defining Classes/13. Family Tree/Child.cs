using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Child
    {
        public string ChildName { get; set; }
        public string ChildBirthday { get; set; }

        public Child(string childName, string childBirthday)
        {
            ChildName = childName;
            ChildBirthday = childBirthday;
        }
    }
}
