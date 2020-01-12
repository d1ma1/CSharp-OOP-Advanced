using System;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(line[1]), double.Parse(line[2]), int.Parse(line[3]));

            var line2 = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(line2[1]), double.Parse(line2[2]), int.Parse(line2[3]));

            var line3 = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(line3[1]), double.Parse(line3[2]), int.Parse(line3[3]));

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                if (input[0]=="Drive" && input[1]=="Car")
                {
                    car.Travel(double.Parse(input[2]), "Car");
                }
                if (input[0] == "Refuel" && input[1] == "Car")
                {
                    car.Refuel(double.Parse(input[2]));
                }
                if (input[0] == "Drive" && input[1] == "Truck")
                {
                    truck.Travel(double.Parse(input[2]), "Truck");
                }
                if (input[0] == "Refuel" && input[1] == "Truck")
                {
                    truck.Refuel(double.Parse(input[2]));
                }
                if (input[0] == "Drive" && input[1] == "Bus")
                {
                    bus.TravelNotEmpty(double.Parse(input[2]), "Bus");
                }
                if (input[0] == "Refuel" && input[1] == "Bus")
                {
                    bus.Refuel(double.Parse(input[2]));
                }
                if (input[0] == "DriveEmpty" && input[1] == "Bus")
                {
                    bus.Travel(double.Parse(input[2]), "Bus");
                }
            }
            Console.WriteLine($"Car: {car.FuelQuant:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuant:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuant:F2}");
        }
    }
}
