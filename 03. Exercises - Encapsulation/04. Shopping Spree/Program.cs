using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var persons = new List<Person>();
            var products = new List<Product>();

            var inputPers = Console.ReadLine();

            try
            {
                var pers = inputPers.Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in pers)
                {
                    var temp = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    var person = new Person(temp[0], double.Parse(temp[1]));
                    persons.Add(person);
                }
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }

            var inputProd = Console.ReadLine();
            try
            {

                var prod = inputProd.Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in prod)
                {
                    var temp = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                    var product = new Product(temp[0], double.Parse(temp[1]));
                    products.Add(product);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            var line = Console.ReadLine();

            while (line != "END")
            {
                var buy = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var findProd = "";
                var price = 0.0;

                foreach (var item in products)
                {
                    if (item.ProductName == buy[1])
                    {
                        findProd = buy[1];
                        price = item.Cost;
                    }
                }
                foreach (var item in persons)
                {
                    if (item.PersonName == buy[0])
                    {
                        if (item.Money >= price)
                        {
                            try
                            {
                                item.Money -= price;
                                item.Bags.Add(new Product(findProd, price));
                                Console.WriteLine($"{item.PersonName} bought {findProd}");
                            }
                            catch (ArgumentException ex)
                            {

                                Console.WriteLine(ex.Message);
                                return;
                            } 
                        }
                        else
                        {
                            Console.WriteLine($"{item.PersonName} can't afford {findProd}");
                        }
                    }
                }
                line = Console.ReadLine();
            }

            foreach (var item in persons)
            {
                if (item.Bags.Count==0)
                {
                    Console.WriteLine($"{item.PersonName} - Nothing bought");
                }
                else
                {
                    var li = new List<string>();
                    foreach (var ppp in item.Bags)
                    {
                        li.Add(ppp.ProductName);
                    }
                    Console.WriteLine($"{item.PersonName} - { String.Join(", ", li)}");
                }
            }
        }
    }
}
