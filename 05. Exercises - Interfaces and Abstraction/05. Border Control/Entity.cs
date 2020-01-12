using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public abstract class Entity
    {
        public string Id { get; set; }

        public Entity(string id)
        {
            Id = id;
        }
                
        public bool IsFake(string n)
        {
            if (Id.EndsWith(n))
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
