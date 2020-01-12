using System;
using System.Collections.Generic;

namespace P03_StudentSystem
{
    public class StudentSystem
    {
        private Dictionary<string, Student> repo;

        public StudentSystem()
        {
            this.Repo = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Repo
        {
            get { return repo; }
            private set { repo = value; }
        }

        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Create")
            {
                var name = args[1];
                var age = int.Parse(args[2]);
                var grade = double.Parse(args[3]);

                if (!repo.ContainsKey(name))
                {
                    var student = new Student(name, age, grade);
                    Repo[name] = student;
                }
            }
            else if (args[0] == "Show")
            {
                var name = args[1];

                if (Repo.ContainsKey(name))
                {
                    var student = Repo[name];

                    var gradeView = GetGrade(student.Grade);                 

                    Console.WriteLine($"{student.Name} is {student.Age} years old. {gradeView}");
                }
            }
            else if (args[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }

        public string GetGrade(double grade)
        {
            string view = "";

            if (grade >= 5.00)
            {
                view += "Excellent student.";
            }
            else if (grade < 5.00 && grade >= 3.50)
            {
                view += "Average student.";
            }
            else
            {
                view += "Very nice person.";
            }

            return view;
        }
    }
}
