using System;

namespace TupleClass
{
    public class StartUp
    {
        public static void Main()
        {
            var input1 = Console.ReadLine().Split();
            var name = input1[0] + " " + input1[1];
            var output1 = new Tuple<string,string>(name, input1[2]);
            Console.WriteLine($"{name} -> {input1[2]}");

            var input2 = Console.ReadLine().Split();
            var output2 = new Tuple<string, string>(input2[0], input2[1]);
            Console.WriteLine($"{input2[0]} -> {input2[1]}");

            var input3 = Console.ReadLine().Split();
            var output3 = new Tuple<string, double>(input3[0], double.Parse(input3[1]));
            Console.WriteLine($"{input3[0]} -> {input3[1]}");
        }
    }
}
