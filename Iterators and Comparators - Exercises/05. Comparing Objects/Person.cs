using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; }
        public int Age { get; }
        public string Town { get; }

        

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public int CompareTo(Person other)
        {
            if (other.Name.CompareTo(Name) ==0 && other.Age.CompareTo(Age) ==0 && other.Town.CompareTo(Town)==0)
            {
                return 0;
            }
            return 1;
        }
    }
}
