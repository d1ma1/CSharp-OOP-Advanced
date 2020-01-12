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
                var line = int.Parse(Console.ReadLine());

                var element = new Box<int>(line);

                Console.WriteLine(element);
            }
        }
    }
}
