using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<double>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                list.Add(double.Parse(line));
            }

            var other = double.Parse(Console.ReadLine());
            var result = CompareCount(list, other);
            Console.WriteLine(result);

        }

        public static int CompareCount<T>(List<T> listche, T element) where T : IComparable
        {
            int count = 0;
            foreach (var item in listche)
            {
                if (element.CompareTo(item) < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

