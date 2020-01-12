using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public string BirthDay { get; set; }

        public Entity(string name, string birthDay)
        {
            Name = name;
            BirthDay = birthDay;
        }
                
        public bool IsFake(string n)
        {
            if (BirthDay.EndsWith(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
