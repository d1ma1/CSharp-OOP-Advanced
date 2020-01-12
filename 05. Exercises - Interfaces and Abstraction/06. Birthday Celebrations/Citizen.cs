using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen: Entity
    {
        public string Id { get; set; }
        public int Age { get; set; }

        public Citizen(string name, string birthDay, int age, string id) : base(name, birthDay)
        {
            Age = age;
            Id = id;
        }
    }
}
