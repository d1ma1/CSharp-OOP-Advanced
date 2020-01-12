using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var entity = new List<Entity>();

            while (input != "End")
            {
                var line = input.Split();

                if (line.Length == 3)
                {
                    Entity citizen = new Citizen(line[2], line[0], int.Parse(line[1]));
                    entity.Add(citizen);
                }

                if (line.Length == 2)
                {
                    Entity robot = new Robot(line[1], line[0]);
                    entity.Add(robot);
                }

                input = Console.ReadLine();
            }

            var n = Console.ReadLine();

            foreach (var citizen in entity)
            {
                if (citizen.IsFake(n))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }
    }
}
