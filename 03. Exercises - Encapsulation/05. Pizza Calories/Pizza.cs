using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> topping;

        public Dough Dough { get; set; }
        public List<Topping> Topping
        {
            get { return topping; }
            set
            {
                topping = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                if (value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            Topping = new List<Topping>();

        }

        public void AddT(Topping topping)
        {
            if (Topping.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            Topping.Add(topping);
        }

        public double totalCalories()
        {
            var total = Dough.CalcDough(); ;

            foreach (var item in Topping)
            {
                total += item.CalcTopping();
            }

            return total;
        }

    }
}
