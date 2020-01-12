using System;

namespace Problem_5.Date_Modifier
{
    public class Program
    {
        static void Main()
        {
            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();

            DateModifier.differ(line1, line2);
        }
    }
}
