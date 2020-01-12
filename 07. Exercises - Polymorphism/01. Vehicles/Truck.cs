using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuant, double fuelConsumptionPerKm) : base(fuelQuant, fuelConsumptionPerKm+1.6)
        {
        }

        public override void Refuel(double fuel)
        {
            FuelQuant += fuel*0.95;
        }
    }
}
