﻿using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Entities.AnimalsFolder
{
    public abstract class Animal : IAnimal
    {
        private int happiness;
        private int energy;

        protected Animal(string name, int energy, int happiness, int procedureTime)
        {
            Name = name;
            Energy = energy;
            Happiness = happiness;
            ProcedureTime = procedureTime;
            Owner = "Centre";
            IsAdopt = false;
            IsChipped = false;
            IsVaccinated = false;
        }

        public string Name { get; }

        public int Happiness
        {
            get { return happiness; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }
                happiness = value;
            }
        }

        public int Energy
        {
            get { return energy; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }
                energy = value;
            }
        }

        public int ProcedureTime { get; set; }

        public string Owner { get; set; }

        public bool IsAdopt { get; set; }

        public bool IsChipped { get; set; }

        public bool IsVaccinated { get; set; }

        public override string ToString()
        {
            return $"Animal type: {this.GetType().Name} - {Name} - Happiness: {Happiness} - Energy: {Energy}";
        }
    }
}
