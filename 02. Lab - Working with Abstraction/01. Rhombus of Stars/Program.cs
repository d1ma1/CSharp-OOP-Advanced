using System;

namespace Problem_1._Rhombus_of_Stars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                PrintRow(num, i);
            }
            for (int j = num-1; j >=1; j--)
            {
                PrintRow(num, j);
            }
        }

        static void PrintRow(int n, int stars)
        {
            for (int i = 0; i < n - stars; i++)
            {
                Console.Write(' ');
            }
            for (int j = 1; j < stars; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine('*');
        }
    }
}
