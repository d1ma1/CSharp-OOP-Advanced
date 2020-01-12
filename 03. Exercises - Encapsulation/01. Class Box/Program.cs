using System;

namespace ClassBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);

            Console.WriteLine($"Surface Area - {box.Area():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LiteralArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");
        }
    }
}
