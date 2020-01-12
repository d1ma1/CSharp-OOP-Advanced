using AnimalCentre.Models.Entities;
using AnimalCentre.Models.Entities.AnimalsFolder;
using System;
using System.Collections.Generic;

namespace AnimalCentre
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var animalCentre = new AnimalCentre();

            var owners = new SortedDictionary<string, List<string>>();

            while (input!="End")
            {
                var output = "";
                try
                {
                    var line = input.Split();
                    if (line[0] == "RegisterAnimal")
                    {
                        output = animalCentre.RegisterAnimal(line[1], line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]));
                    }
                    if (line[0] == "Chip")
                    {
                        output = animalCentre.Chip(line[1], int.Parse(line[2]));
                    }
                    if (line[0] == "Vaccinate")
                    {
                        output = animalCentre.Vaccinate(line[1], int.Parse(line[2]));
                    }
                    if (line[0] == "Fitness")
                    {
                        output = animalCentre.Fitness(line[1], int.Parse(line[2]));
                    }
                    if (line[0] == "Play")
                    {
                        output = animalCentre.Play(line[1], int.Parse(line[2]));
                    }
                    if (line[0] == "DentalCare")
                    {
                        output = animalCentre.DentalCare(line[1], int.Parse(line[2]));
                    }
                    if (line[0] == "NailTrim")
                    {
                        output = animalCentre.NailTrim(line[1], int.Parse(line[2]));
                    }
                    if (line[0] == "Adopt")
                    {
                        output = animalCentre.Adopt(line[1], line[2]);

                        if (!owners.ContainsKey(line[2]))
                        {
                            owners[line[2]] = new List<string>();
                        }

                        owners[line[2]].Add(line[1]);
                    }
                    if (line[0] == "History")
                    {
                        output = animalCentre.History(line[1]);
                    }
                }
                catch (Exception ex)
                {
                    output = ex.GetType().Name + ": " + ex.Message;
                }
                Console.WriteLine(output);
                input = Console.ReadLine();
            }

            foreach (var kvp in owners)
            {             
                Console.WriteLine("--Owner: " + kvp.Key);

                var anims = "";
                foreach (var item in kvp.Value)
                {
                    anims += " " + item;
                }
                Console.WriteLine("    - Adopted animals:" + anims);            
            }
        }
    }
}
