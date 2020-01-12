using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            ListyIterator<string> listy = new ListyIterator<string>();
           // listy.Listy = new List<string>();

            while (input!="END")
            {
                var line = input.Split();
                var cmd = line[0];

                if (cmd == "Create")
                {
                        for (int i = 1; i < line.Length; i++)
                        {
                           listy.Listy.Add(line[i]);
                        }
                }
                if (cmd== "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                if (cmd == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                if (cmd == "Print")
                {
                    try
                    {
                        Console.WriteLine(listy.Print());
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (cmd == "PrintAll")
                {
                    Console.WriteLine(string.Join(' ', listy));
                }
                input = Console.ReadLine();
            }
        }
    }
}
