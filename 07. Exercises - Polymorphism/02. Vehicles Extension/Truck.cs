using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuant, double fuelConsumptionPerKm, int tank) : base(fuelQuant, fuelConsumptionPerKm+1.6, tank)
        {
        }

        public override void Refuel(double fuel)
        {
            if (fuel + FuelQuant > Tank)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                FuelQuant += fuel * 0.95;
            }
        }
    }
}
