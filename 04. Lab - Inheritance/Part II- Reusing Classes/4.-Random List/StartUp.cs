using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var list = new RandomList();
            list.Add("x0");
            list.Add("y0");
            list.Add("x1");
            list.Add("y1");
            list.Add("x2");
            list.Add("y2");

            Console.WriteLine(list.RandomString());
        }
    }
}
