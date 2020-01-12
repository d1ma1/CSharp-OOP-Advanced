using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Start()
        {
            return $"Breaaak!";
        }

        public string Stop()
        {
            return $"Stop!";
        }

        public override string ToString()
        {
            return $"{Color} Seat {Model}";
        }
    }
}
