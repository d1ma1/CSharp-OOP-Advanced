using System;
using System.Collections.Generic;

namespace Google
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var listPersons = new List<Person>();

            while (input != "End")
            {
                var line = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person currPerson = null;

                var count = 0;
                foreach (var person in listPersons)
                {
                    if (person.Name == line[0])
                    {
                        currPerson = person;
                        count++;
                    }
                }

                if (count == 0)
                {
                    currPerson = new Person(line[0]);
                }

                if (line[1] == "company")
                {
                    currPerson.Company = new Company(line[2], line[3], decimal.Parse(line[4]));
                }

                if (line[1] == "car")
                {
                    currPerson.Car = new Car(line[2], int.Parse(line[3]));
                }

                if (line[1] == "pokemon")
                {
                    currPerson.Pokemons.Add(new Pokemon(line[2], line[3]));
                }
 
                if (line[1] == "parents")
                {
                    currPerson.Parents.Add(new Parent(line[2], line[3]));
                }

                if (line[1] == "children")
                {
                    currPerson.Children.Add(new Child(line[2], line[3]));
                }

                if (count==0)
                {                    
                    listPersons.Add(currPerson);
                }
                input = Console.ReadLine();
            }

            var output = Console.ReadLine();
            foreach (var person in listPersons)
            {
                if (person.Name == output)
                {
                    Console.WriteLine(person.Name);

                    Console.WriteLine("Company:");
                    if (person.Company != null) Console.WriteLine(person.Company.ToString());

                    Console.WriteLine("Car:");
                    if (person.Car != null) Console.WriteLine(person.Car.ToString());

                    Console.WriteLine("Pokemon:");
                    if (person.Pokemons.Count>0)
                    {
                        foreach (var item in person.Pokemons)
                        {
                            Console.WriteLine(item.ToString());
                        }  
                    }

                    Console.WriteLine("Parents:");
                    if (person.Parents.Count>0)
                    {
                        foreach (var item in person.Parents)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }

                    Console.WriteLine("Children:");
                    if (person.Children.Count>0)
                    {
                        foreach (var item in person.Children)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                }
            }
        }
    }
}
