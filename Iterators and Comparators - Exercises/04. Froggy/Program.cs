using System;
using System.Linq;

namespace Froggy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            var list = new Lake(input);

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
