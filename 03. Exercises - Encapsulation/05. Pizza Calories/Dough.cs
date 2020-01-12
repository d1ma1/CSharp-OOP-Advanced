using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        private string flourType;
        private string bakingTechnique;
        private int weight { get; set; }

        public string FlourType
        {
            get { return flourType; }
            set
            {
                if (value!= "white" && value!= "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (value != "homemade" && value != "crispy" && value != "chewy")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }
        public int Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double CalcDough()
        {
            var weight = 2.0*this.weight;

            if (FlourType == "white")
            {
                weight *= 1.5;
            }
            if (FlourType == "wholegrain")
            {
                weight *= 1.0;
            }
            if (BakingTechnique == "crispy")
            {
                weight *= 0.9;
            }
            if (BakingTechnique == "chewy")
            {
                weight *= 1.1;
            }
            if (BakingTechnique == "homemade")
            {
                weight *= 1.0;
            }

            return weight;
        }
    }
}
