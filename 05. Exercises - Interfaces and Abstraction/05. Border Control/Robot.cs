using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : Entity
    {
        public string Model { get; set; }

        public Robot(string id, string model) : base(id)
        {
            Model = model;
        }
    }
}
