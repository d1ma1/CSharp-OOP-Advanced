using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Tyre Tire1 { get; set; }
        public Tyre Tire2 { get; set; }
        public Tyre Tire3 { get; set; }
        public Tyre Tire4 { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tyre tire1, Tyre tire2, Tyre tire3, Tyre tire4)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;

            this.Tire1 = tire1;
            this.Tire2 = tire2;
            this.Tire3 = tire3;
            this.Tire4 = tire4;
        }
    }
}
