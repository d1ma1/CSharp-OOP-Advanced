using System;
using System.Linq;

namespace CustomList
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var listOfStrings = new Listche<string>();

            while (input!="END")
            {
                var line = input.Split();

                if (line[0]=="Add")
                {
                    listOfStrings.Add(line[1]);
                }
                
                if (line[0] == "Remove")
                {
                    listOfStrings.Remove(int.Parse(line[1]));
                }
                if (line[0] == "Contains")
                {
                    Console.WriteLine(listOfStrings.Contains(line[1])); 
                }
                if (line[0] == "Swap")
                {
                   listOfStrings.Swap(int.Parse(line[1]),int.Parse(line[2]));
                }
                if (line[0]=="Greater")
                {
                    Console.WriteLine(listOfStrings.CountGreaterThan(line[1]));
                }
                if (line[0] == "Max")
                {
                    Console.WriteLine(listOfStrings.Max());
                }
                if (line[0] == "Min")
                {
                    Console.WriteLine(listOfStrings.Min());
                }
                if (line[0] == "Print")
                {
                    foreach (var item in listOfStrings)
                    {
                        Console.WriteLine(item);
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
