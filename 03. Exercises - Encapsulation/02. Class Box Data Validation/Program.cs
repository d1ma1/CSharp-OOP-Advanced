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

            try
            {
                var box = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {box.Area():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.LiteralArea():F2}");
                Console.WriteLine($"Volume - {box.Volume():F2}");
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message); ;
            }
           
        }
    }
}
