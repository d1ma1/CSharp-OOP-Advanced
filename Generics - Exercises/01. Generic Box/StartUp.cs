using System;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var element = new Box<string>(input);

            Console.WriteLine(element);
        }
    }
}
