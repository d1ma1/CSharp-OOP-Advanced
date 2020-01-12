using System;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();

                var element = new Box<string>(line);

                Console.WriteLine(element);
            }
        }
    }
}
