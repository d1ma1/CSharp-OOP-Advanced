using System;

namespace Ferrari_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var obj = new Ferrari(line);

            Console.WriteLine(obj);
        }
    }
}
