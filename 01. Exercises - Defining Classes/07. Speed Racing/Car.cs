using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; }
        public double FuelAmount { get; set; }
        public double FuelConsumption  { get; set; }
        public double DistanceTraveled { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model; 
            this.FuelAmount = fuelAmount;
            this.FuelConsumption  = fuelConsumption;
            this.DistanceTraveled = 0.0;
        }

        public void calc(double distance)
        {
            if (distance * FuelConsumption <= FuelAmount)
            {
                FuelAmount -= FuelConsumption * distance;
                DistanceTraveled += distance;            
            }

            else
            {              
               Console.WriteLine("Insufficient fuel for the drive");
            }
            
        }
                                    
    }
}
