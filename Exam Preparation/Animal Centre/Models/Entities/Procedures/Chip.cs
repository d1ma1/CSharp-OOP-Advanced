using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Entities.Procedures
{
    public class Chip : Procedure
    {
        public Chip() : base()
        {
        }

        public override string History()
        {
           return base.History();
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness -= 5;

            if (animal.IsChipped)
            {
                throw new ArgumentException($"{animal.Name} is already chipped");
            }
            else
            {
                animal.IsChipped = true;
            }
        }
    }
}
