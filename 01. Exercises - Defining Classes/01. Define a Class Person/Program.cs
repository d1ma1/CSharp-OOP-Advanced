using System;

public class Program
{
    static void Main()
    {
        var firstPerson = new Person();
        firstPerson.Name = "Pesho";
        firstPerson.Age = 20;

        var secondPerson = new Person
        {
            Name = "Gosho",
            Age = 18
        };

        var thirdPerson = new Person
        {
            Name = "Stamat"
        };
        thirdPerson.Age = 43;

        Console.WriteLine("name: " + firstPerson.Name + ", age:" + firstPerson.Age);
        Console.WriteLine("name: " + secondPerson.Name + ", age:" + secondPerson.Age);
        Console.WriteLine("name: " + thirdPerson.Name + ", age:" + thirdPerson.Age);
    }
}

