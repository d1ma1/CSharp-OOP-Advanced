using AnimalCentre.Models.Contracts;
using AnimalCentre.Models.Entities.AnimalsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Entities.Procedures
{
    public abstract class Procedure : IProcedure
    {
        private List<IAnimal> procedureHistory;

        public IReadOnlyCollection<IAnimal> ProcedureHistory
        {
            get
            {
                return procedureHistory.AsReadOnly();
            }
        }

        public object Enviropment { get; private set; }

        protected Procedure()
        {
            procedureHistory = new List<IAnimal>();
        }

        public virtual void DoService(IAnimal animal, int procedureTime)
        {
            if (animal.ProcedureTime<procedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.ProcedureTime -= procedureTime;
        }

        public virtual string History()
        {
            var output = $"{this.GetType().Name}";

            foreach (var poc in procedureHistory)
            {
                output+= Environment.NewLine + $"    - {poc.Name} - Happiness: {poc.Happiness} - Energy: {poc.Happiness}";
               
            }

            return output;
        }
    }
}
