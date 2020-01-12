using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var people = new Family();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(' ');
            var person = new Person();

            person.Name = line[0];
            person.Age = int.Parse(line[1]);

            if (person.Age > 30) people.AddMember(person);
        }

        people.Print();
    }
}

