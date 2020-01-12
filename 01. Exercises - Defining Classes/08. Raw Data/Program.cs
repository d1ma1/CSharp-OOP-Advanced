using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var inp = Console.ReadLine().Split();

                var model = inp[0];
                var engine = new Engine(int.Parse(inp[1]), int.Parse(inp[2]));
                var cargo = new Cargo(int.Parse(inp[3]), inp[4]);
                var tire1 = new Tyre(double.Parse(inp[5]), int.Parse(inp[6]));
                var tire2 = new Tyre(double.Parse(inp[7]), int.Parse(inp[8]));
                var tire3 = new Tyre(double.Parse(inp[9]), int.Parse(inp[10]));
                var tire4 = new Tyre(double.Parse(inp[11]), int.Parse(inp[12]));

                var car = new Car(model, engine, cargo, tire1, tire2, tire3, tire4);

                dict[model] = car;
            }

            var cmd = Console.ReadLine();
            if (cmd == "flamable")
            {
                foreach (var value in dict.Values)
                {
                   if (value.Cargo.CargoType == "flamable" && value.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(value.Model);
                    }
                }
            }

            if (cmd == "fragile")
            {
                foreach (var value in dict.Values)
                {
                    if (value.Cargo.CargoType == "fragile" && (value.Tire1.TirePressure < 1 || value.Tire2.TirePressure < 1 || value.Tire3.TirePressure < 1 || value.Tire4.TirePressure < 1))
                    {
                        Console.WriteLine(value.Model);
                    }
                }
            }
        }
    }
}
