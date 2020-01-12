using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot
    {
        public string Id { get; set; }
        public string Model { get; set; }

        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }
    }
}
