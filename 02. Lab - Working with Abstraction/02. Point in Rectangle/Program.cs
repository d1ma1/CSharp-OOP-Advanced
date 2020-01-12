using System;
using System.Linq;

namespace PointInRectangle
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var left = new Point(input[0], input[1]);
            var right = new Point(input[2], input[3]);

            var rect = new Rectangle(left, right);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                var point = new Point(line[0], line[1]);

                Console.WriteLine(rect.Contains(point));
            }
        }
    }
}
