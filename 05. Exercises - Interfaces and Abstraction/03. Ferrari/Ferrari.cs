using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari_
{
    public class Ferrari : IFerarri
    {
        public string Model { get;set; }
        public string Driver { get;set; }

        public Ferrari(string driver)
        {
            Driver = driver;
            Model = "488-Spider";
        }

        public string Braking()
        {
            return "Brakes!";
        }

        public string Gasing()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"{Model}/{Braking()}/{Gasing()}/{Driver}";
        }
    }
}
