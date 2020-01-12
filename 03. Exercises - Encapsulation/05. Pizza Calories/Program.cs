using System;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var pizzaName = "";
            try
            {
                pizzaName = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
            }
            catch (Exception)
            {
                Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                return;
            }
          

            var doughInput = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dough dough = null;

            try
            {
                dough = new Dough(doughInput[1].ToLower(), doughInput[2].ToLower(), int.Parse(doughInput[3]));
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            Pizza pizza = null;
            try
            {
                pizza = new Pizza(pizzaName, dough);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }


            var line = Console.ReadLine();

            while (line!="END")
            {
                var splitTop = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Topping topping = null;
                try
                {
                    topping = new Topping(splitTop[1].ToLower(), int.Parse(splitTop[2]));
                    pizza.AddT(topping);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }

                line = Console.ReadLine();
            }

            //if (pizza.Topping.Count > 10)
            //{
            //    throw new ArgumentException("Number of toppings should be in range [0..10].");
            //}

            Console.WriteLine($"{pizza.Name} - {pizza.totalCalories():F2} Calories.");
        }
    }
}
