using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuant, double fuelConsumptionPerKm) : base(fuelQuant, fuelConsumptionPerKm+0.9)
        {
        }
    }
}
