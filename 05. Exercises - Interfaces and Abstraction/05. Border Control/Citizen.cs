using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen: Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(string id, string name, int age) : base(id)
        {
            Name = name;
            Age = age;
        }
    }
}
