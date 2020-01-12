using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string personName;
        private double money;
        public List<Product> Bags { get; set; }

        public string PersonName
        {
            get { return personName; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                personName = value;
            }
        }
        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public Person(string personName, double money)
        {
            PersonName = personName;
            Money = money;
            Bags = new List<Product>();
        }
    }
}
