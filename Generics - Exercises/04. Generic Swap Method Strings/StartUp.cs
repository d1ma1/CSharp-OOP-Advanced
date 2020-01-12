using System;
using System.Collections.Generic;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var box = new Box<string>(line);
                list.Add(box);
            }

            var ind = Console.ReadLine().Split();
            SwapElements(list, int.Parse(ind[0]), int.Parse(ind[1]));
            list.ForEach(x => Console.WriteLine(x));

            void SwapElements(List<Box<string>> listche,int a, int b)
            {
                var temp = listche[a];
                listche[a] = listche[b];
                listche[b] = temp;
            }

            
        }
    }
}

