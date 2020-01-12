using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuant { get; set; }
        public double FuelConsumptionPerKm {get;set;}
        public int Tank { get; set; }

        public Vehicle(double fuelQuant, double fuelConsumptionPerKm, int tank)
        {
            if (fuelQuant>tank)
            {
                fuelQuant = 0;
            }
            else
            {
                FuelQuant = fuelQuant;
            }
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            Tank = tank;
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
            if (fuel + FuelQuant > Tank)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else if (fuel <=0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                FuelQuant += fuel;
            }  
        }

        public virtual void TravelNotEmpty(double v1, string v2)
        {
            Console.WriteLine(String.Empty);
        }
    }
}
