using System;
using System.Collections.Generic;
using WildFarm.Models;

namespace WildFarm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var list = new List<Animal>();

            while (input!="End")
            {
                var line = input.Split();

                if (line[0] == "Cat" )
                {
                    Animal cat = new Cat(line[1], double.Parse(line[2]),0, line[3], line[4]);

                    var food = Console.ReadLine().Split();

                    Console.WriteLine(cat.ProduceSound());

                    if (food[0] == "Vegetable" || food[0] == "Meat")
                    {
                        cat.FoodEaten += int.Parse(food[1]);
                        cat.Weight += 0.3 * int.Parse(food[1]);
                    }
                    else
                    {
                        Console.WriteLine($"Cat does not eat {food[0]}!");
                    }

                    list.Add(cat);
                }
                if (line[0] == "Tiger")
                {
                    Animal tiger = new Tiger(line[1], double.Parse(line[2]), 0, line[3], line[4]);

                    var food = Console.ReadLine().Split();

                    Console.WriteLine(tiger.ProduceSound());

                    if (food[0] == "Meat")
                    {
                        tiger.FoodEaten += int.Parse(food[1]);
                        tiger.Weight += 1 * int.Parse(food[1]);
                    }
                    else
                    {
                        Console.WriteLine($"Tiger does not eat {food[0]}!");
                    }

                    list.Add(tiger);
                }
                if (line[0] == "Dog")
                {
                    Animal dog = new Dog(line[1], double.Parse(line[2]), 0, line[3]);

                    var food = Console.ReadLine().Split();

                    Console.WriteLine(dog.ProduceSound());

                    if (food[0] == "Meat")
                    {
                        dog.FoodEaten += int.Parse(food[1]);
                        dog.Weight += 0.40 * int.Parse(food[1]);
                    }
                    else
                    {
                        Console.WriteLine($"Dog does not eat {food[0]}!");
                    }

                    list.Add(dog);
                }
                if (line[0] == "Owl")
                {
                    Animal owl = new Owl(line[1], double.Parse(line[2]), 0, double.Parse(line[3]));

                    var food = Console.ReadLine().Split();

                    Console.WriteLine(owl.ProduceSound());

                    if (food[0] == "Meat")
                    {
                        owl.FoodEaten += int.Parse(food[1]);
                        owl.Weight += 0.25 * int.Parse(food[1]);
                    }
                    else
                    {
                        Console.WriteLine($"Owl does not eat {food[0]}!");
                    }

                    list.Add(owl);
                }
                if (line[0] == "Mouse")
                {
                    Animal mouse = new Mouse(line[1], double.Parse(line[2]), 0, line[3]);

                    var food = Console.ReadLine().Split();

                    Console.WriteLine(mouse.ProduceSound());

                    if (food[0] == "Fruit" || food[0] == "Vegetable")
                    {
                        mouse.FoodEaten += int.Parse(food[1]);
                        mouse.Weight += 0.10 * int.Parse(food[1]);
                    }
                    else
                    {
                        Console.WriteLine($"Mouse does not eat {food[0]}!");
                    }

                    list.Add(mouse);
                }
                if (line[0] == "Hen")
                {
                    Animal hen = new Hen(line[1], double.Parse(line[2]), 0, double.Parse(line[3]));

                    var food = Console.ReadLine().Split();

                    Console.WriteLine(hen.ProduceSound());

                    hen.FoodEaten += int.Parse(food[1]);
                    hen.Weight += 0.35 * int.Parse(food[1]);
                    list.Add(hen);
                }
                
                input = Console.ReadLine();
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
