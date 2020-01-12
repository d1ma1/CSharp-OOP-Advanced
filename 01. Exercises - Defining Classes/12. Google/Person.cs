using System;
using System.Collections.Generic;

namespace Google
{
    class Person
    {
        public string Name { get; set; }

        public Car Car { get; set; }

        public Company Company { get; set; }

        public List<Child> Children { get; set; }

        public List<Parent> Parents { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Person(string name)
        {
            Name = name;
            Company = null;
            Children = new List<Child>();
            Parents = new List<Parent>();
            Pokemons = new List<Pokemon>();
        }
    }
}
