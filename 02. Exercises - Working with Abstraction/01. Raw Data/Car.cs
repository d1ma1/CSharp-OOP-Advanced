using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;

            this.tires = new List<Tire>();
        }
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tire> tires;
    }
}
