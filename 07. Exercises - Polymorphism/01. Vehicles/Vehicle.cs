using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuant { get; set; }
        public double FuelConsumptionPerKm {get;set;}

        public Vehicle(double fuelQuant, double fuelConsumptionPerKm)
        {
            FuelQuant = fuelQuant;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public void Travel(double distance, string veh)
        {
            if (distance * FuelConsumptionPerKm <= FuelQuant)
            {
                FuelQuant -= distance * FuelConsumptionPerKm;
                Console.WriteLine(veh + " travelled " + distance + " km");
            }
            else
            {
                Console.WriteLine(veh + " needs refueling");
            }
        }

        public virtual void Refuel(double fuel)
        {
            FuelQuant += fuel;
        }
    }
}
