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

                if (line[0]== "Citizen")
                {
                    Entity citizen = new Citizen(line[1], line[4], int.Parse(line[2]), line[3]);
                    entity.Add(citizen);
                }

                if (line[0]=="Pet")
                {
                    Entity pet = new Pet(line[1], line[2]);
                    entity.Add(pet);
                }

                input = Console.ReadLine();
            }

            var n = Console.ReadLine();

            foreach (var citizen in entity)
            {
                if (citizen.IsFake(n))
                {
                    Console.WriteLine(citizen.BirthDay);
                }
            }
        }
    }
}
