using MordorsCruelPlan.Food;
using System;

namespace MordorsCruelPlan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();

            var sum = 0;

            for (int i = 0; i < line.Length; i++)
            {
                sum += FoodFactory.GetFood(line[i]).Point;
            }

            Console.WriteLine(sum);

            if (sum < -5)
            {
                Console.WriteLine("Angry");
            }
            if (sum >=1 && sum <=15)
            {
                Console.WriteLine("Happy");
            }
            if (sum >= -5 && sum <=-1)
            {
                Console.WriteLine("Sad");
            }
            if (sum > 15)
            {
                Console.WriteLine("JavaScript");
            }

        }
    }
}
