using System;
using System.Collections.Generic;

namespace RectangleIntersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dict = new Dictionary<string, Rectangle>();

            var line = Console.ReadLine().Split();
            var n = int.Parse(line[0]);
            var m = int.Parse(line[1]);

            for (int i = 0; i < n; i++)
            {
                var inp = Console.ReadLine().Split();

                dict[inp[0]] = new Rectangle(inp[0], double.Parse(inp[1]), double.Parse(inp[2]), double.Parse(inp[3]), double.Parse(inp[4]));
            }

            for (int i = 0; i < m; i++)
            {
                var inp = Console.ReadLine().Split();

                Rectangle r1 = dict[inp[0]];
                Rectangle r2 = dict[inp[1]];
                r1.check(r2);
            }
        }
    }
}
