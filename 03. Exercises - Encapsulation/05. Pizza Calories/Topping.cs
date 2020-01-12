using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private int weightTopping;

        public int WeightTopping
        {
            get { return weightTopping; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(new CultureInfo("en-US").TextInfo.ToTitleCase(Type) + " weight should be in the range [1..50].");
                }
                weightTopping = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    throw new ArgumentException("Cannot place " + new CultureInfo("en-US").TextInfo.ToTitleCase(value) + " on top of your pizza.");
                }
                type = value;
            }
        }

        public Topping(string type, int weightTopping)
        {
            Type = type;
            WeightTopping = weightTopping;
        }

        public double CalcTopping()
        {
            var result = 2.0 * weightTopping;

            if (type == "meat")
            {
                result *= 1.2;
            }
            if (type == "veggies")
            {
                result *= 0.8;
            }
            if (type == "cheese")
            {
                result *= 1.1;
            }
            if (type == "sauce")
            {
                result *= 0.9;
            }

            return result;
        }

    }
}
