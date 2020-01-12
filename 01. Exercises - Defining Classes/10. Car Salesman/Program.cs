using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dictEngine = new Dictionary<string, Engine>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                dictEngine[line[0]] = new Engine(line[0], int.Parse(line[1]));

                if (line.Length >= 3)
                {
                    int temp;
                    if (int.TryParse(line[2], out temp))
                    {
                        dictEngine[line[0]].Displacement = line[2];
                    }
                    else
                    {
                        dictEngine[line[0]].Efficiency = line[2];
                    }
                }
                if (line.Length == 4)
                {
                    dictEngine[line[0]].Efficiency = line[3];
                }
            }

            var m = int.Parse(Console.ReadLine());
            var listCar = new List<Engine>();

            for (int i = 0; i < m; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Engine engine = null;

                if (dictEngine.ContainsKey(line[1]))
                {
                    engine = dictEngine[line[1]];
                }

                var car = new Car(line[0], engine);

                if (line.Length >= 3)
                {
                    int temp;
                    if (int.TryParse(line[2], out temp))
                    {
                        car.Weight = line[2];
                    }
                    else
                    {
                        car.Color = line[2];
                    }
                }
                if (line.Length == 4)
                {
                    car.Color = line[3];
                }

                Console.WriteLine(car.ToString());
            }
        }
    }
}
