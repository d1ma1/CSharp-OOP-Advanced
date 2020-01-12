using System;

namespace Mankind
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var line1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var student = new Student(line1[0],line1[1],line1[2]);

                var line2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var worker = new Worker(line2[0],line2[1],decimal.Parse(line2[2]),decimal.Parse(line2[3]));

                Console.WriteLine($"First Name: {student.FirstName}" + Environment.NewLine +
                                $"Last Name: {student.lastName}" + Environment.NewLine +
                                $"Faculty number: {student.FacultyNumber}");

                Console.WriteLine();
                Console.WriteLine($"First Name: {worker.FirstName}" + Environment.NewLine +
                                $"Last Name: {worker.lastName}" + Environment.NewLine +
                                $"Week Salary: {worker.WeekSalary:F2}" + Environment.NewLine +
                                $"Hours per day: {worker.WorkHours:F2}" + Environment.NewLine +                               
                                $"Salary per hour: {worker.WeekSalary/(5 * worker.WorkHours):F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
