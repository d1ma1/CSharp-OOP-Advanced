using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Entities.Procedures
{
    public class Play : Procedure
    {
        public Play() : base()
        {
        }

        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);

            animal.Happiness +=12;
            animal.Energy -= 6;
        }

    }
}
