using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Parent
    {
        public string ParentName { get; set; }
        public string ParentBirthday { get; set; }

        public Parent(string parentName, string parentBirthday)
        {
            ParentName = parentName;
            ParentBirthday = parentBirthday;
        }
    }
}
