using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<Person>();

            while (input!="END")
            {
                var line = input.Split();

                var person = new Person(line[0], int.Parse(line[1]), line[2]);

                list.Add(person);
                input = Console.ReadLine();
            }

            var n = int.Parse(Console.ReadLine());

            var checkPerson = list[n-1];

            var countEqual = 0;
            var countNotEqual = 0;

            foreach (var item in list)
            {
                if (item.CompareTo(checkPerson) == 0)
                {
                    countEqual++;
                }
                else
                {
                    countNotEqual++;
                }
            }

            if (countEqual > 1)
            {
                Console.WriteLine($"{countEqual} {countNotEqual} {list.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
