using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Entities;
using AnimalCentre.Models.Entities.AnimalsFolder;
using AnimalCentre.Models.Entities.Procedures;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre
{
    public class AnimalCentre
    {
        Hotel hotel = new Hotel();

        public Dictionary<string, IAnimal> animals;

        Procedure procedure = null;

       private List<IAnimal> procedureHistoryChip;
       private List<IAnimal> procedureHistoryD;
       private List<IAnimal> procedureHistoryF;
       private List<IAnimal> procedureHistoryN;
       private List<IAnimal> procedureHistoryP;
       private List<IAnimal> procedureHistoryV;

        public AnimalCentre()
        {
            animals = new Dictionary<string, IAnimal>();
            procedureHistoryChip = new List<IAnimal>();
            procedureHistoryD = new List<IAnimal>();
            procedureHistoryF = new List<IAnimal>();
            procedureHistoryN = new List<IAnimal>();
            procedureHistoryP = new List<IAnimal>();
            procedureHistoryV = new List<IAnimal>();
        }

        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            Animal animal = null; 
            if (type == "Cat")
            {
                animal = new Cat(name, energy, happiness, procedureTime);
            }
            if (type == "Dog")
            {
                animal = new Dog(name, energy, happiness, procedureTime);
            }
            if (type == "Lion")
            {
                animal = new Lion(name, energy, happiness, procedureTime);
            }
            if (type == "Pig")
            {
                animal = new Pig(name, energy, happiness, procedureTime);
            }

            if (!animals.ContainsKey(name))
            {
                animals.Add(name, animal);
                hotel.Accommodate(animal);

                return $"Animal {name} registered successfully";
            }
            else
            {
                throw new ArgumentException($"Animal {name} already exist");
            }
           
        }

        public string Chip(string name, int procedureTime)
        {
            ThrowEx(name);

            procedure = new Chip();

            procedure.DoService(animals[name], procedureTime);

            procedureHistoryChip.Add(animals[name]);

            return $"{name} had chip procedure";
        }

        public string Vaccinate(string name, int procedureTime)
        {
            ThrowEx(name);

            procedure = new Vaccinate();
            procedure.DoService(animals[name], procedureTime);

            procedureHistoryV.Add(animals[name]);

            return $"{name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            ThrowEx(name);

            procedure = new Fitness();
          procedure.DoService(animals[name], procedureTime);

            procedureHistoryF.Add(animals[name]);

            return $"{name} had fitness procedure";
        }

        public string Play(string name, int procedureTime)
        {
            ThrowEx(name);
            procedure = new Play();
            procedure.DoService(animals[name], procedureTime);
            procedureHistoryP.Add(animals[name]);

            return $"{name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            ThrowEx(name);
            procedure = new DentalCare();
            procedure.DoService(animals[name], procedureTime);
            procedureHistoryD.Add(animals[name]);
            return $"{name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            ThrowEx(name);
            procedure = new NailTrim();
            procedure.DoService(animals[name], procedureTime);
            procedureHistoryN.Add(animals[name]);
            return $"{name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            ThrowEx(animalName);
            hotel.Adopt(animalName, owner);

            if (animals[animalName].IsChipped)
            {
                return $"{owner} adopted animal with chip";
            }
            else
            {
                return $"{owner} adopted animal without chip";
            }
        }

        public string History(string type)
        {
            var output = "";

            if (type == "Chip")
            {
                output = "Chip";
                foreach (var poc in procedureHistoryChip)
                {
                   output += Environment.NewLine + $"Animal type: {poc.GetType().Name} - {poc.Name} - Happiness: {poc.Happiness} - Energy: {poc.Energy}";

                }
            }
            if (type == "DentalCare")
            {
                output = "DentalCare";
                foreach (var poc in procedureHistoryD)
                {
                    output += Environment.NewLine + $"Animal type: {poc.GetType().Name} - {poc.Name} - Happiness: {poc.Happiness} - Energy: {poc.Energy}";

                }
            }
            if (type == "Fitness")
            {
                output = "Fitness";
                foreach (var poc in procedureHistoryF)
                {
                    output += Environment.NewLine + $"Animal type: {poc.GetType().Name} - {poc.Name} - Happiness: {poc.Happiness} - Energy: {poc.Energy}";

                }
            }
            if (type == "NailTrim")
            {
                output = "NailTrim";
                foreach (var poc in procedureHistoryN)
                {
                    output += Environment.NewLine + $"Animal type: {poc.GetType().Name} - {poc.Name} - Happiness: {poc.Happiness} - Energy: {poc.Energy}";

                }
            }
            if (type == "Play")
            {
                output = "Play";
                foreach (var poc in procedureHistoryP)
                {
                    output += Environment.NewLine + $"Animal type: {poc.GetType().Name} - {poc.Name} - Happiness: {poc.Happiness} - Energy: {poc.Energy}";

                }
            }
            if (type == "Vaccinate")
            {
                output = "Vaccinate";
                foreach (var poc in procedureHistoryV)
                {
                    output += Environment.NewLine + $"Animal type: {poc.GetType().Name} - {poc.Name} - Happiness: {poc.Happiness} - Energy: {poc.Energy}";

                }
            }

            return output;
        }

        private void ThrowEx(string name)
        {
            if (!animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }
            
        }
    }
}
