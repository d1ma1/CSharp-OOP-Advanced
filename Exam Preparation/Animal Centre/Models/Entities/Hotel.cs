using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Entities.AnimalsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Entities
{
    public class Hotel : IHotel
    {
        private int capacity=10;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private IDictionary<string, IAnimal> animals;

        public IReadOnlyDictionary<string, IAnimal> Animals { get;  }

        public Hotel()
        {
            animals = new Dictionary<string, IAnimal>();
        }

        public void Accommodate(IAnimal animal)
        {
            if (Capacity == 0)
            {
                throw new InvalidOperationException("Not enough capacity");
            }
            else if (animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }
            else
            {
                animals[animal.Name] = animal;
                Capacity--;
            }
        }

        public void Adopt(string animalName, string owner)
        {
            if (!animals.ContainsKey(animalName))
            {
                throw new ArgumentException("Animal {animalName} does not exist");
            }
            else
            {
                animals[animalName].Owner = owner;
                animals[animalName].IsAdopt = true;
                animals.Remove(animalName);
                Capacity++;
            }
        }
    }
}
