using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var citizens = new List<Citizen>();
            var rebels = new List<Rebel>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                if (line.Length == 4)
                {
                    var citizen = new Citizen(line[0], line[3], int.Parse(line[1]), line[2]);
                    citizens.Add(citizen);
                }
                if (line.Length == 3)
                {
                    var rebel = new Rebel(line[0], int.Parse(line[1]), line[2]);
                    rebels.Add(rebel);
                }
            }

            var input = Console.ReadLine();
            var sum = 0;

            while (input != "End")
            {
                foreach (var citizen in citizens)
                {
                    if (citizen.Name == input)
                    {
                        citizen.BuyFood();
                    }
                }
                foreach (var rebel in rebels)
                {
                    if (rebel.Name == input)
                    {
                        rebel.BuyFood();
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(citizens.Sum(b => b.Food) + rebels.Sum(b => b.Food));
        }
    }
}
