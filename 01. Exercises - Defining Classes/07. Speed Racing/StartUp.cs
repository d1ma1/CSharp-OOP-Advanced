using System;
using System.Collections.Generic;
using System.Reflection;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();

                dict[line[0]] = new Car(line[0], double.Parse(line[1]), double.Parse(line[2]));
            }

           var input = Console.ReadLine();

            while (input != "End")
            {
                var cmd = input.Split();

                if (dict.ContainsKey(cmd[1]))
                {
                   dict[cmd[1]].calc(double.Parse(cmd[2]));

                }
                
                input = Console.ReadLine();
            }

            foreach (var value in dict.Values)
            {
                Console.WriteLine($"{value.Model} {value.FuelAmount:F2} {value.DistanceTraveled}");
                
            }
        }
    }
}
