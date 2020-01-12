using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var list = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var empl = new Employee(
                line[0],
                decimal.Parse(line[1]),
                line[2],
                line[3]
            );

            if (line.Length > 4)
            {
                if (line[4].Contains("@"))
                {
                    empl.email = line[4];
                }
                else
                {
                    empl.age = int.Parse(line[4]);
                }
            }

            if (line.Length > 5)
            {
                if (line[5].Contains("@"))
                {
                    empl.email = line[5];
                }
                else
                {
                    empl.age = int.Parse(line[5]);
                }
            }

            list.Add(empl);
        }

        var result = list
            .GroupBy(e => e.department)
            .Select(e => new
            {
                Department = e.Key,
                AverageSalary = e.Average(emp => emp.salary),
                Employees = e.OrderByDescending(emp => emp.salary)
            })
            .OrderByDescending(dep => dep.AverageSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.Department}");

        foreach (var item in result.Employees)
        {
            Console.WriteLine($"{item.name} {item.salary:F2} {item.email} {item.age}");
        }

    }
}


