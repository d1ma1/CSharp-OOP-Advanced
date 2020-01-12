using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuant, double fuelConsumptionPerKm, int tank) : base(fuelQuant, fuelConsumptionPerKm, tank)
        {
        }

        public override void TravelNotEmpty(double distance, string veh)
        {
            if (distance * (FuelConsumptionPerKm+ 1.4)<= FuelQuant)
            {
                FuelQuant -= distance * (FuelConsumptionPerKm+1.4);
                Console.WriteLine(veh + " travelled " + distance + " km");
            }
            else
            {
                Console.WriteLine(veh + " needs refueling");
            }
        }
    }
}
