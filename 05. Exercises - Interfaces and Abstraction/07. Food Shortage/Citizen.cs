using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen: Entity,IBuyer
    {
        public string Id { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }

        public Citizen(string name, string birthDay, int age, string id) : base(name, birthDay)
        {
            Age = age;
            Id = id;
            Food = 0;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
