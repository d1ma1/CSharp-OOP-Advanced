using System;

namespace TupleClass
{
    public class StartUp
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split();
            var name = line[0] + " " + line[1];
            var output = new Tuple<string,string,string>(name, line[2], line[3]);
            Console.WriteLine($"{output.Item1} -> {output.Item2} -> {output.Item3}");

            line = Console.ReadLine().Split();
            output = new Tuple<string, string, string>(line[0], line[1], line[2]);
            Console.WriteLine($"{output.Item1} -> {output.Item2} -> {output.Item3=="drunk"}");

            var line3 = Console.ReadLine().Split();
            var output3 = new Tuple<string, double, string>(line3[0], double.Parse(line3[1]), line3[2]);
            Console.WriteLine($"{output3.Item1} -> {output3.Item2:F1} -> {output3.Item3}");
        }
    }
}
